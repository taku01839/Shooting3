using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAtt = 0.5f;
    public int attDa = 10;
    public GameObject bullet;

    private GameObject player;
    //PlayerHealthを入れる
    private EnemyHelth enemyHelth;
    private bool playerInRange;
    private float time;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //playerHealth = player.GetComponent<PlayerHealth>();
        enemyHelth = GetComponent<EnemyHelth>();
    }

    /// <summary>
    /// プレイヤーが一定範囲に入ったとき
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    private void Update()
    {
        //デバック
        Attack();
    }

    private void Attack()
    {
        time = 0f;
        var bulletclo = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(bulletclo, 10);
    }
}
