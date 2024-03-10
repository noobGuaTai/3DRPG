using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Javelin : Weapon
{
    public float bulletSpeed;
    public GameObject bulletPrefab;

    GameObject bulletGo;
    float attackCooldown = 0.5f;
    float lastAttackTime = -1f;

    void Start(){
        SpawnBullet();
    }

    public override void Attack()
    {
        if(bulletGo != null && Time.time - lastAttackTime >= attackCooldown){
            bulletGo.transform.parent = null;
            bulletGo.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            
            lastAttackTime = Time.time;//更新攻击时间
            Invoke("SpawnBullet", attackCooldown);
        } else {
            return;
        }
        
    }

    void SpawnBullet(){
        bulletGo = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletGo.transform.parent = transform;
    }
}
