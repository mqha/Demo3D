using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealthPoint;
    public Animator anim;

    public UnityEvent onDie;

    private int healthPoint;

    private bool IsDead => healthPoint <= 0;

    private void Start() => healthPoint = maxHealthPoint;

    public void TakeDamage(int damage)
    {
        if (IsDead)
            return;
        healthPoint -= damage;
        if (IsDead)
        {
            Die();
        }

    }

    private void Die()
    {
        onDie.Invoke();

        if(anim)
        anim.SetTrigger("Die");
    }
}
