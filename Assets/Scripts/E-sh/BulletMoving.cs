using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    public Vector3 dir = Vector3.left;
    [SerializeField] float speed = 0.05f;
    private void Update()
    {
        gameObject.transform.Translate(dir * speed*Time.deltaTime);
    }

}
