using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFire : MonoBehaviour
{
    [SerializeField] GameObject fire;
    [SerializeField] Transform FirePos;
    float y_player = 0;
    float y_fire = 0;
    float gap = 0;
    float MAX = 10f;
    

    // Update is called once per frame
    void Update()
    {
        gap = y_player - y_fire;
        if(gap > MAX)
        {
                  
        }

    }
}
