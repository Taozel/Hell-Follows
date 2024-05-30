using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class BossHealth : MonoBehaviour
{
    public float value = 100;
    private float Enemy;
    public Animator animator;
    private bool isDead = false;

    public void Start()
    {
    }

    public void DealDamage(float damage)
    {
        if (isDead) return;

        value -= damage;
        if (value <= 0)
        {
            EnemyDeath();
        }
        else
        {
            animator.SetTrigger("hit");
        }
    }

    private void EnemyDeath()
    {
        isDead = true;
        animator.SetTrigger("death");
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;        
    }

    public void Death()
    {
        if (isDead == true)
        {
            SceneManager.LoadScene("MainMenu");
        }
                
    }

}
