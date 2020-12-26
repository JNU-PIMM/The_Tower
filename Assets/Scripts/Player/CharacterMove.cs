using UnityEngine;
using System.Collections;
using System;
public class CharacterMove : MonoBehaviour

{
    public Action<int> collidedWithEnemyEvent;
    public Action pressUpEvent;
    public Action pressDownEvent;
    public Action gameoverEvent;
    // Update is called once per frame
    public float height;
    public int life;
    int speed = 10; //스피드
    float xMove, yMove;
    bool keyInput = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collidedWithEnemyEvent(life);

            if (life > 0)
                life = life - 1;
            else
                gameoverEvent();
            //게임종료
        }


    }

    void Update()
    {
        xMove = 0;
        yMove = 0;

        if(keyInput)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                xMove = speed * Time.deltaTime;
            else if (Input.GetKey(KeyCode.LeftArrow))
                xMove = -speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                height += speed * Time.deltaTime;
                pressUpEvent();
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                height += -speed * Time.deltaTime;
                pressDownEvent();
                    
            }
 
            this.transform.Translate(new Vector3(xMove, yMove, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            keyInput = false;
            StartCoroutine(WaitForIt());
        }
    }

    IEnumerator WaitForIt()
    {
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime;
            transform.position += new Vector3(0, -1.0f, 0) * Time.deltaTime;
            yield return null;
        } 
        keyInput = true;
    }
}