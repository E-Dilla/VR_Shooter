using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_One : MonoBehaviour {

    private Animator _animator;
    private NavMeshAgent _navMeshAgent;

    public GameObject Player;

    public float health = 50f;

    // Use this for initialization
    void Start() {

        _animator = GetComponent<Animator>();

        _navMeshAgent = GetComponent<NavMeshAgent>();

    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        _animator.Play("Hit", 0, 0.25f);

        if (health <= 0f)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
