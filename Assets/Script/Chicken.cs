using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
    NavMeshAgent agent;
    SpriteRenderer sprite;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        agent.SetDestination(collision.transform.position);
    }

    void Update()
    {
        Animation();
    }

    private void Animation()
    {
        if (agent.velocity.magnitude > 0)
        {
            animator.SetBool("isWalking", true);
        }

        else
        {
            animator.SetBool("isWalking", false);
        }

        if (agent.velocity.x > 0) //facing right
        {
            sprite.flipX = false;
        }

        else if (agent.velocity.x < 0) //facing left
        {
            sprite.flipX = true;
        }
    }
}
