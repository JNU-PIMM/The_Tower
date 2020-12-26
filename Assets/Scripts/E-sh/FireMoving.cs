using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMoving : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    void Update()
    {
        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
