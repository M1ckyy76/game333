using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class patrolBehavior : StateMachineBehaviour
{
    float timer;
    List<Transform> points = new List<Transform>();
    NavMeshAgent agent;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        Transform poinsObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform t in poinsObject)
            points.Add(t);
        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].position);

        
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(points[Random.Range(0, points.Count)].position);
        timer += Time.deltaTime;
        if (timer > 10)
            animator.SetBool("isPatroling", false);


    }

    
   override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        
    }

  
}
