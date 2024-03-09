using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    NavMeshAgent playerAgent;
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Move") && EventSystem.current.IsPointerOverGameObject() == false){
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
