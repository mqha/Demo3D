using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public Animator anim;
    public int damage;
    public Health playerHealth;

    public void StartAttack() => anim.SetBool("IsAttacking", true);

    public void StopAttack() => anim.SetBool("IsAttacking", false);

    public void OnAttack(int index)
    {
        playerHealth.TakeDamage(damage);
        if (index == 1)
        {
            Player.Instance.playerUi.ShowLeft();
        }
        else
        {
            Player.Instance.playerUi.ShowRight();
        }
    }

}
