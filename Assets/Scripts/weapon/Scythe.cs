using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scythe : Weapon
{
    public const string ANIM_PARM_ATTACK = "attack";
    Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void Update(){
        
    }

    public override void Attack(){
        anim.SetTrigger(ANIM_PARM_ATTACK);
    }

    public override void UnAttack()
    {
        anim.ResetTrigger(ANIM_PARM_ATTACK);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Enemy"){
            print("Trigger with" + other.name);
        }
    }
}
