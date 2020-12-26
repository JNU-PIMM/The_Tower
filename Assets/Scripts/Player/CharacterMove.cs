using UnityEngine;
using System.Collections;
public class CharacterMove : MonoBehaviour

{
    // Update is called once per frame
    public float height;
    int speed = 10; //스피드
    float xMove, yMove;
    bool keyInput = true;
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
                height = speed * Time.deltaTime;
            else if (Input.GetKey(KeyCode.DownArrow))
                height = -speed * Time.deltaTime;
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