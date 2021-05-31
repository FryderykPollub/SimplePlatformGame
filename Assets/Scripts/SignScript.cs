using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignScript : MonoBehaviour
{
    [SerializeField] private Collider2D signCollider;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject messageBox;

    void Update()
    {
        messageBox.SetActive(false);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(signCollider.transform.position, 0.5f, playerMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                messageBox.SetActive(true);
                break;
            }
        }
    }
}
