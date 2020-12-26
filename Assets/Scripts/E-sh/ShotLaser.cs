using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLaser : MonoBehaviour
{

    [SerializeField] GameObject laser;
    [SerializeField] GameObject laser_warning;
    [SerializeField] Transform FirePos;

    private float TimeLeft = 3.0f;
    private float nextTime = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            StartCoroutine(createLaser());
        }
    }
    IEnumerator createLaser()
    {
        GameObject warning_laser = Instantiate(laser_warning, FirePos.transform.position, FirePos.transform.rotation);
        yield return new WaitForSeconds(1f);
        Destroy(warning_laser);

        GameObject warning_laser2 = Instantiate(laser_warning, FirePos.transform.position, FirePos.transform.rotation);
        yield return new WaitForSeconds(1f);
        Destroy(warning_laser2);

        GameObject shoted_laser = Instantiate(laser, FirePos.transform.position, FirePos.transform.rotation);
        yield return new WaitForSeconds(1f);
        Destroy(shoted_laser);

    }
}
