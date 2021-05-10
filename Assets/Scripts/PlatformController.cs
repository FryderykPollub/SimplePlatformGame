using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Transform waypointStart;
    [SerializeField] private Transform waypointEnd;
    [Range(1, 20)] [SerializeField] private float moveSpeed = 1f;

    private Transform nextWaypoint;
    private bool IsActive = false;

    private void Start()
    {
        nextWaypoint = waypointStart;
    }

    void FixedUpdate()
    {
        if(IsActive) MovePlatform();
    }

    void MovePlatform()
    {
        transform.position = Vector2.MoveTowards(transform.position, nextWaypoint.position, moveSpeed * Time.deltaTime);
        if (transform.position == waypointStart.position)
        {
            nextWaypoint = waypointEnd;
        }
        else if (transform.position == waypointEnd.position)
        {
            nextWaypoint = waypointStart;
        }
    }

    public void SetActive(bool changer)
    {
        IsActive = changer;
    }
}
