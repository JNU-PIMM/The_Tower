using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    public Vector3 dir = Vector3.left;
    [SerializeField] float speed = 0.05f;
    [SerializeField] GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 터진다
            Instantiate(Effects.Instance.bulletEffect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


    private void Update()
    {
        gameObject.transform.Translate(dir * speed*Time.deltaTime);
    }

}
