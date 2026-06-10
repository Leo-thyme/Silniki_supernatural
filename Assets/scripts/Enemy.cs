
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public PlayerHealth player_health;

    public List<Transform> patrolPoints;
    public float patrolPointReachDistance = 0.5f;
    public float followDistance = 10f;
    public float stopFollowDistance = 15f;
    public float attackDistance = 2f;
    public float attackCooldown = 1.5f;
    public int minAttackDamage = 10;
    public int maxAttackDamage = 40;

    private int currentPatrolIndex;
    private float lastAttackTime;
    private bool isFollowing;
    


    void Start()
    {
        GoToNextPatrolPoint();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackDistance)
        {
            Attack();
        }
        else if (distanceToPlayer <= followDistance)
        {
            isFollowing = true;
            FollowPlayer();
        }
        else if (isFollowing && distanceToPlayer <= stopFollowDistance)
        {
            FollowPlayer();
        }
        else
        {
            isFollowing = false;
            Patrol();
        }
    }

    public void GoToNextPatrolPoint()
    {
        agent.isStopped = false;
        agent.SetDestination(patrolPoints[currentPatrolIndex].position);

        currentPatrolIndex++;

        if(currentPatrolIndex >= patrolPoints.Count)
        {
            currentPatrolIndex = 0;
        }

    }

    public void Patrol()
    {
        if(!agent.pathPending && agent.remainingDistance <= patrolPointReachDistance)
        {
            GoToNextPatrolPoint();
        }
    }

    public void FollowPlayer()
    {
        agent.isStopped = false;
        agent.SetDestination(player.position);
    }

    public void Attack()
    {
        agent.isStopped = true;

        Vector3 direction = player.position - transform.position;
        direction.y = 0f;

        if (direction == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);

        if (Time.time < lastAttackTime + attackCooldown)
        {
            return;
        }

        lastAttackTime = Time.time;

        player_health.Take_Damage(Random.Range(minAttackDamage, maxAttackDamage));

        
    }

    
}
