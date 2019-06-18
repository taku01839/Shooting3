using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelth : MonoBehaviour
{
    [SerializeField] private int startHP = 100;
    [SerializeField] private ParticleSystem deadParticle;

    private int currentHP;
    private bool isDead;

    private void Awake()
    {
        deadParticle = GetComponent<ParticleSystem>();

        currentHP = startHP;
    }

    public void Damage(int atkp)
    {
        if (isDead) return;

        currentHP -= atkp;
        if(currentHP <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        isDead = true;
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        deadParticle.Play();
        Destroy(deadParticle, 1.5f);
    }
}
