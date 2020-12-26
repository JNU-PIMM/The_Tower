using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public int scoreValue;
    public CharacterMove player;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        player.gameoverEvent += StopScore;
        player.gameoverEvent += Gameover;
    }

    // Update is called once per frame
    void Update()
    {
        score += scoreValue;
    }

    void StopScore()
    {
        scoreValue = 0;
    }

    void Gameover()
    {
        Debug.Log("종료");
    }
}
