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

    public bool missionComplete;

    void Start()
    {
        enemyCountdown = 30;
        displayScore = 30;
        missionCompleteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (enemyCountdown != displayScore)
        {
            displayScore = enemyCountdown;
            scoreUI.text = displayScore.ToString();

            if (Score.enemyCountdown == 0)
            {
                
                MissionCompleted();
            }
        }
    }

    public void MissionCompleted()
    {
        missionCompleteAudio.Play();
        missionComplete = true;
    }
}
