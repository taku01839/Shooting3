using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //PlayerHealthを入れる
    public int attkDa = 10;
    public int speed = 1;

    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerHelthをGetComする
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        transform.position += new Vector3(0, 0, speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //ダメージを入れるスクリプトを
        }
    }
}
