using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour
{
    public Rigidbody player_Rigidbody;
    public Animator weapon_animator;
    private bool Is_In_Defense;

    public float attackDistance = 3;
    public int minDamage = 20;
    public int maxDamage = 30;
    public float attackCooldown = 0.5f;
    public float maxAttackAngle = 45f;
    public float enemyListRefreshTime = 1f;
    private float lastAttackTime;
    private float nextEnemyListRefreshTime;

    private List<EnemyHealth> enemies = new List<EnemyHealth>();

    public void Update()
    {
        weapon_animator.SetFloat("Velocity",player_Rigidbody.linearVelocity.magnitude);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weapon_animator.SetTrigger("Attack");

            //float distanceToEnemy = Vector3.Distance(transform.position, player.position);
            // badanie pozycji wszystkich enemy na swiecie real time

            //if (distanceToEnemy <= attackDistance)
            //{
            //    Attack();
            //}
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (Is_In_Defense)
            {
                return;
            }

            Is_In_Defense = true;
            weapon_animator.SetBool("Is_in_defense",true);
            weapon_animator.SetTrigger("Defense");
        }
        
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Is_In_Defense = false;
            weapon_animator.SetBool("Is_in_defense", false);
        }
    }

    public void RefreshEnemyList()
    {
        enemies.Clear();
        EnemyHealth[]foundenemies = FindObjectsByType<EnemyHealth>(sortMode: FindObjectsSortMode.InstanceID);
    }
}
