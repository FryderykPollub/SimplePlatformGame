using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerkiller : MonoBehaviour
{
    [SerializeField] private Image h1;
    [SerializeField] private Image h2;
    [SerializeField] private Image h3;
    [SerializeField] private Collider2D bottomCollider;
    [SerializeField] private Collider2D upperCollider;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private SpriteRenderer playerSprite;
    //[SerializeField] private GameObject enemy;
    [SerializeField] private LayerMask enemyMask;

    private int health;

    private void Start()
    {
        health=PlayerPrefs.GetInt("Health");
        if(health < 3)
        {
            h3.enabled = false;
            h2.enabled = false;
        }
    }

    private void Update()
    {
        hurt();
    }

    public void hurt()
    {
        Collider2D[] colliders2 = Physics2D.OverlapCircleAll(bottomCollider.transform.position, 0.5f, enemyMask);
        for (int i = 0; i < colliders2.Length; i++)
        {
            if (colliders2[i].gameObject != gameObject)
            {
                healthHearts();
                break;
            }
        }
    }

    public void healthHearts()
    {
        if (health > 1)
        {
            if (health > 2)
            {
                h3.enabled = false;
                //hurtAnimation();
                health = 2;
            }
            else
            {
                h2.enabled = false;
                //hurtAnimation();
                health = 1;
            }

        }
        else
        {
            h1.enabled = false;
            killed();
        }
    }

    void hurtAnimation()
    {
        playerAnimator.SetBool("IsHurt", true);
        playerAnimator.SetBool("IsHurt", false);
    }

    void killed()
    {
        upperCollider.enabled = false;
        bottomCollider.enabled = false;
        Invoke("Restart", 2.5f);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
