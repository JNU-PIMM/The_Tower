using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControler : MonoBehaviour
{
 
    public float scrollSpeed;
    public enum MoveDirection 
    { 
        Down = -1, 
        Stay = 0,
        Up = 1
    }
    public Transform background;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.player.pressUpEvent += UpBackground;
        GameManager.instance.player.pressDownEvent += DownBackground;
    }

    // Update is called once per frame
    void Update()
    {

        ResetPosition();
    }

    void UpBackground()
    {
        SetBackgroundmoving(MoveDirection.Down);
    }
    void DownBackground()
    {
        SetBackgroundmoving(MoveDirection.Up);
    }

    public void SetBackgroundmoving(MoveDirection diretion)
    {
        if (diretion == MoveDirection.Down)
        {
            background.position += new Vector3(0, -scrollSpeed, 0) * Time.deltaTime;
        }
        if (diretion == MoveDirection.Up)
        {
            background.position += new Vector3(0, scrollSpeed, 0) * Time.deltaTime;
        }
    }

    void ResetPosition()
    {
        // if() 만약에 카메라 밖을 넘어가면 
        // background의 position을 0으로 바꾼다.

        if (background.position.y >= 11.25f)
            background.position = new Vector3(0, 0, 0);
        if (background.position.y <= -11.25f)
            background.position = new Vector3(0, 0, 0);
    }
}
