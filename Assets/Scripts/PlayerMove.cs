using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    NavMeshAgent playerAgent;
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Move")){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool isCollide = Physics.Raycast(ray, out hit);
            if(isCollide){
                if(hit.collider.tag == "Ground"){
                    playerAgent.stoppingDistance = 0;
                    playerAgent.SetDestination(hit.point);
                } else if(hit.collider.tag == "Interactable"){
                    hit.collider.GetComponent<Interactable>().OnClick(playerAgent);
                }
                
            }
        }
    }
}
