using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public Slider _slider;
    public GameObject bombslider;
    [SerializeField]
    private GameObject bullet;
    Slider nowBombSlider;
    int bombcount;


    [SerializeField]
    private GameObject bomb;

    private bool shootAble = true;

    // Start is called before the first frame update
    void Start()
    {
        _slider.value = _slider.minValue;

        bombcount = bombslider.transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        BombShoot();
        Cool();
        

        if (_slider.value == _slider.maxValue)
        {
            //ゲージマックスで撃てなくなる
            shootAble = false;
        }
        if (_slider.value == _slider.minValue)
        {
            //ゲージ最低値になると撃てるようになる
            shootAble = true;
        }
    }

    private void Shoot()
    {
        //弾発射
        if (Input.GetKey(KeyCode.Z) && shootAble)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            _slider.value += _slider.maxValue / 500;
        }
    }

    private void Cool()
    {
        if (!Input.GetKey(KeyCode.Z) && shootAble)
        {
            _slider.value -= _slider.maxValue / 800;
        }
        else if (!shootAble)
        {
            _slider.value -= _slider.maxValue / 200;
        }
    }

    private void IsShootAble()
    {
    }

    private void BombShoot()
    {
        if (Input.GetKeyDown(KeyCode.X) && bombcount != 0)
        {
            Instantiate(bomb, transform.position, transform.rotation);

            nowBombSlider =
            bombslider.transform.GetChild(bombcount - 1).GetComponent<Slider>();

            bombcount -= 1;

            nowBombSlider.value = nowBombSlider.minValue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            nowBombSlider.value = nowBombSlider.maxValue;
            bombcount += 1;

            if (bombcount > bombslider.transform.childCount)
            {
                bombcount = bombslider.transform.childCount;
            }

            nowBombSlider =
            bombslider.transform.GetChild(bombcount - 1).GetComponent<Slider>();

        }
    }
}
