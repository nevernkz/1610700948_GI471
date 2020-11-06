using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class W5_AIMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent navAgent;
    private W5_PlayerMovement playerTarget;
    private void Start()
    {
        navAgent = this.GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        FindingPlayer();
        UpdateMovement();


    }
    private void UpdateMovement()
    {
        if (playerTarget == null)
            return;

            navAgent.SetDestination(playerTarget.transform.position);
    }
    private void FindingPlayer()
    {
        if(playerTarget==null)
        {
            playerTarget = FindObjectOfType<W5_PlayerMovement>();
        }

    }
}
