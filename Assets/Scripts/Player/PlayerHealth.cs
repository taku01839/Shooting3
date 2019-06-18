using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHp;
    [SerializeField]
    private Slider _slider;
    private int currentHp;

    // Start is called before the first frame update
    void Start()
    {
        _slider.maxValue = maxHp;
        _slider.value = _slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Debug();
        }

        if (CurrentHP() <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Damage(int damage)
    {
        _slider.value -= damage;
    }

    void Debug()
    {
        Damage(50);
    }

    public int CurrentHP()
    {
        currentHp = (int)_slider.value;
        return currentHp;
    }

    private void OnDestroy()
    {
        //SceneManager.LoadScene("Player");
    }
}
