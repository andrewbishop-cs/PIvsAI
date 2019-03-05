using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;

        agent = GetComponent("NavMeshAgent") as NavMeshAgent;

        NavMeshHit closestHit;
        if (NavMesh.SamplePosition(transform.position, out closestHit, 100f, NavMesh.AllAreas))
        {
            transform.position = closestHit.position;
            agent.enabled = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = Vector3.Distance(target.position, transform.position);
        float distance = Vector3.Distance(target.position, transform.position);

        if (agent.transform.position.y >= -0.001)
        {
            agent.SetDestination(target.position);
        }

        


        // kills the agent if it falls in a hole
        if (agent.transform.position.y <= -50)
        {
            Score.score++;
            Destroy(gameObject);
        }
        

    }

}
