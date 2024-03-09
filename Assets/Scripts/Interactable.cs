using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    NavMeshAgent playerAgent;
    bool isInteractable = false;
    public void OnClick(NavMeshAgent playerAgent) {
        this.playerAgent = playerAgent;
        isInteractable = false;
        playerAgent.stoppingDistance = 2;
        playerAgent.SetDestination(transform.position);
    }

    protected virtual void Interact(){
        Debug.Log("Interacting with " + transform.tag);
    }

    void Update(){
        if(playerAgent != null && playerAgent.pathPending == false && isInteractable == false){
            if(playerAgent.remainingDistance <= playerAgent.stoppingDistance){
                Interact();
                isInteractable = true;
            }
        }
    }
}
