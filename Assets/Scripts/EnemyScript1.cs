using UnityEngine;
using UnityEngine.Events;

public class EnemyScript1 : MonoBehaviour
{
    [SerializeField] private Transform waypointStart;
    [SerializeField] private Transform waypointEnd;
    [SerializeField] private LayerMask playerMask;
    [Range(1, 10)][SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Collider2D killingCollider;
    [SerializeField] private Collider2D hurtingCollider;

    private bool exists = true; 
    private Transform nextWaypoint;
    /*
    public UnityEvent playerHitted; 
    
    private void Awake()
    {
        if(playerHitted == null) playerHitted = new UnityEvent();
    }
    */
    private void Start()
    {
        nextWaypoint = waypointStart;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, nextWaypoint.position, moveSpeed * Time.deltaTime);
        if (transform.position == waypointStart.position)
        {
            Flip();
            nextWaypoint = waypointEnd;
        }
        else if (transform.position == waypointEnd.position)
        {
            Flip();
            nextWaypoint = waypointStart;
        }
    }

    void FixedUpdate()
    {
        if (exists)
        {
            beKilled();
            //hurt();
        }
    }

    void beKilled()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(killingCollider.transform.position, 0.5f, playerMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                Destroy(killingCollider);
                Destroy(hurtingCollider);
                Destroy(gameObject, 2);
                exists = false;
            }
        }
    }
    
    void Flip()
    {
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
 
    /*
    void hurt()
    {
        Collider2D[] colliders2 = Physics2D.OverlapCircleAll(hurtingCollider.transform.position, 0.5f, playerMask);
        for (int i = 0; i < colliders2.Length; i++)
        {
            if (colliders2[i].gameObject != gameObject)
            {
                playerHitted.Invoke();
                break;
            }
        }
    }
    */
}
