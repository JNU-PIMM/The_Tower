using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMoving : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    void Update()
    {
        gameObject.transform.position = new Vector3(0, 1, 0);
    }
}
