using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int enemyCountdown;
    private int displayScore;
    public TextMeshPro scoreUI;

    public AudioSource missionCompleteAudio;
    

    void Start()
    {
        enemyCountdown = 30;
        displayScore = 30;
    }

    void Update()
    {
        if(enemyCountdown != displayScore)
        {
            displayScore = enemyCountdown;
            scoreUI.text = displayScore.ToString();
        }
    }

    void ScoreAtZero()
    {
        if(enemyCountdown <= 0)
        {
            MissionComplete();
        }
    }

    void MissionComplete()
    {
        missionCompleteAudio.Play();
    }
    

}
