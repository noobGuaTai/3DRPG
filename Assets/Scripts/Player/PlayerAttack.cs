using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon weapon;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(weapon != null){
            if(Input.GetButtonDown("Attack")){
                weapon.Attack();
            } else {
                weapon.UnAttack();
            }
        }
        
    }

    public void LoadWeapon(Weapon weapon){
        this.weapon = weapon;
    }

    public void UnloadWeapon(){
        weapon = null;
    }
}
