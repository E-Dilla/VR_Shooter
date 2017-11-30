using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_One : MonoBehaviour {

    private Animator _animator;
    private NavMeshAgent _navMeshAgent;

    public GameObject Player;

    public float health = 50f;

    private Transform target;

    public float attackDistance = 20f;

    private bool isDead = false;
    private bool isAttacking = false;

    private HitDection hitDection;


    // Use this for initialization
    void Start() {

        _animator = GetComponent<Animator>();

        _navMeshAgent = GetComponent<NavMeshAgent>();

        hitDection = GetComponent<HitDection>();

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        
        _animator.Play("Hit", 0, 0.25f);
        //_animator.SetTrigger("Hit");

        if (health <= 0f)
        {
            Die();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isDead)
        {
            _navMeshAgent.SetDestination(target.position);
            _animator.SetFloat("Follow", Mathf.Abs(_navMeshAgent.velocity.x) + (_navMeshAgent.velocity.z));
            float dist = Vector3.Distance(transform.position, target.position);
            if (dist < 1f && target != null)
            {
                Attack();
                Debug.Log("DoAttack");
            }
            else
            {
                _navMeshAgent.enabled = true;
                _animator.SetBool("Attack", false);
                isAttacking = false;
            }
        }
    }

    public void Die()
    {
        isDead = true;
        _navMeshAgent.enabled = false;
        _animator.SetTrigger("Dying");
        Destroy(GetComponent<Collider>());
        _animator.SetBool("Attack", false);
    }

    public void Attack()
    {
        isAttacking = true;
        _animator.SetBool("Attack", true);
    }
}
