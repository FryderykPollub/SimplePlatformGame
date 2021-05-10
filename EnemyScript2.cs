using System;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    [SerializeField] private float walkingStart;
    [SerializeField] private float walkingEnd;
    [SerializeField] private LayerMask WhatKills;
    [Range(10, 100)] [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private Collider2D killingCollider;
    [SerializeField] private Collider2D normalCollider;
    [SerializeField] private GameObject ToSelfDestruction;

    private Transform waypointStart;
    private Transform waypointEnd;
    private Vector2 walkingStartVector;
    private Vector2 walkingEndVector;

    private void Start()
    {
        Vector2 basedPosition = transform.position;

        walkingStartVector.Set(walkingStart, basedPosition.y);
        walkingEndVector.Set(walkingEnd, basedPosition.y);

        waypointStart = Vector3(walkingStartVector.x, walkingStartVector.y, 0);
        waypointEnd = Vector3(walkingEndVector.x, walkingEndVector.y, 0);

        Transform Vector3(float x, float y, int v)
        {
            throw new NotImplementedException();
        }
    }

    void Update()
    {
        if (transform.position.x == waypointStart.position.x)
        {
            Flip();
        }
        else if (transform.position.x == waypointEnd.position.x)
        {
            Flip();
        }
    }

    void FixedUpdate()
    {
        if (transform.position == waypointStart.position)
        {
            MoveToEnd();
        }
        else if (transform.position == waypointEnd.position)
        {
            MoveToStart();
        }

        Collider2D[] colliders = Physics2D.OverlapCircleAll(killingCollider.transform.position, 0.5f, WhatKills);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                Destroy(killingCollider);
                Destroy(normalCollider);
                Destroy(ToSelfDestruction);
            }
        }
    }

    void MoveToStart()
    {
        while (transform.position != waypointStart.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypointStart.position, moveSpeed * Time.deltaTime);
        }
    }
    void MoveToEnd()
    {
        while (transform.position != waypointEnd.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypointEnd.position, moveSpeed * Time.deltaTime);
        }
    }

    private void Flip()
    {
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
