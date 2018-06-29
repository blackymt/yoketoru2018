using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSystem : Singleton<GameSystem>
{
    [SerializeField]
    TextMeshProUGUI scoreText;


    int score;

    // Use this for initialization
    void Start()
    {
        //score = 0;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.A))
        {
            score += 10;
            //scoreText.text = "" + score;
            scoreText.text = score.ToString("d7");
        }
    }

    public void SetScoreText(TextMeshProUGUI txt)
    {
        scoreText = txt;
    }

    void updateScore()
    {
        scoreText.text = score.ToString("D7");
    }

}
