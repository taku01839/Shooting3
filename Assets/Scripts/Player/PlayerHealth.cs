using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int currentHp;
    [SerializeField]
    private int maxHp;
    [SerializeField]
    private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider.maxValue = maxHp;
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Damage(int damage)
    {
        currentHp -= damage;
    }
}
