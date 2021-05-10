using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Animations;

public class CrankController : MonoBehaviour
{ 
    [SerializeField] private Collider2D crankCollider;
    [SerializeField] private LayerMask playerMask;
    public Animator animator;

    private bool changer;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public BoolEvent ActivateEvent;
    private void Awake()
    {
        if (ActivateEvent == null)
            ActivateEvent = new BoolEvent();
    }

    private void Start()
    {
        animator.SetBool("IsUp", false);
    }

    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(crankCollider.transform.position, 0.5f, playerMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                Activator();
                break;
            }
        }
    }

    void Activator()
    {
        if (Input.GetButtonDown("Interaction"))
        {
            changer = animator.GetBool("IsUp");
            animator.SetBool("IsUp", !changer);
            ActivateEvent.Invoke(!changer);
        }
    }
}
