using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class GemCollector : MonoBehaviour
{
    [SerializeField] private LayerMask player;
    [SerializeField] private Collider2D gemCollider;
    private bool exists = true;
    private bool collected = false;

    [Header("Events")]
    [Space]

    public UnityEvent ScoreCount;

    private void Awake()
    {
        if (ScoreCount == null)
            ScoreCount = new UnityEvent();
    }

    private void FixedUpdate()
    {
        if (exists)
        {
            collect();

            if (collected)
            {
                Destroy(gameObject);
                ScoreCount.Invoke();
                exists = false;
            }
        }
    }

    void collect()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(gemCollider.transform.position, 0.5f, player);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                collected = true;
            }
        }
    }
}
