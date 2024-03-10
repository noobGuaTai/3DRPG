using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JavelinBullet : MonoBehaviour
{
    Rigidbody rb;
    Collider collider;
    float startTime;

    void Start(){
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        startTime = Time.time;
        
    }

    void Update(){
        if(gameObject.transform.parent == null && Time.time - startTime > 10f){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision){
        rb.velocity = Vector3.zero;
        rb.isKinematic = true;
        collider.enabled = false;

        Destroy(gameObject, 5f);
    }
    
}
