using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHelth : MonoBehaviour
{
    [SerializeField] int currentHp;
    [SerializeField] int maxHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Damage(int damage)
    {
        damage -= maxHP;
    }
}
