using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        agent.SetDestination(collision.transform.position);
    }
}
