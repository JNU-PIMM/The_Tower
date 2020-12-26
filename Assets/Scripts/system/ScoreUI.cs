using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text text;
    
    // Start is called before the first frame update

    void Start()
    {
        GameManager.instance.player.collidedWithEnemyEvent += SetScoretext;
        SetScoretext(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScoretext(int score)
    {
        text.text = score.ToString();

    }
}
