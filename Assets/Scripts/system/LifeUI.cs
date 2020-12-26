using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUI : MonoBehaviour
{
    public List<GameObject> lifes;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.player.collidedWithEnemyEvent += SetLifeimg;
        SetLifeimg(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLifeimg(int life)
    {

       for(int i = 0; i < lifes.Count; i++)
        {
            if (i < life)
                lifes[i].SetActive(true);
            else 
                lifes[i].SetActive(false);

        }
    }

}
