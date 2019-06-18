using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public Slider _slider;
    [SerializeField]
    private GameObject bullet;

    private bool shootAble = true;

    // Start is called before the first frame update
    void Start()
    {
        _slider.value = _slider.minValue;
    }

    // Update is called once per frame
    void Update()
    {
        //弾発射
        if (Input.GetKey(KeyCode.Z) && shootAble)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            _slider.value += _slider.maxValue / 500;
        }
        else if (!shootAble)
        {
            _slider.value -= _slider.maxValue / 200;
        }
        else
        {
            _slider.value -= _slider.maxValue / 800;
        }

        if (_slider.value == _slider.maxValue)
        {
            //ゲージマックスで打てなくなる
            shootAble = false;
        }
        if (_slider.value == _slider.minValue)
        {
            //ゲージ最低値で打てる
            shootAble = true;
        }
    }
}
