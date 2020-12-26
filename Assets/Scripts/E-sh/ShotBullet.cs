﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform FirePos;
    [SerializeField] int dir;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //복제한다. 
            //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            GameObject shoted_bullet=Instantiate(bullet, FirePos.transform.position, FirePos.transform.rotation);
            if(dir == 1)
                shoted_bullet.GetComponent<BulletMoving>().dir = Vector3.right;
            else
                shoted_bullet.GetComponent<BulletMoving>().dir = Vector3.left;
        }
        
    }
}
