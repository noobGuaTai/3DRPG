using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent enemyAgent;

    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        
    }

    IEnumerator PatrolState(){
        while(true){
            Vector3 randomPosition = FindRandomPosition();
            enemyAgent.SetDestination(randomPosition);
            
        }
    }

    Vector3 FindRandomPosition(){
        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));//方向
        return transform.position + randomDirection.normalized * Random.Range(2f, 5f);//距离
    }

}
