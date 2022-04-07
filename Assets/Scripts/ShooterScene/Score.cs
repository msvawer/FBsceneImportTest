using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int enemyCountdown;
    private int displayScore;
    public TextMeshPro scoreUI;


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

    //  private void Awake()
    //{
    //     enemyCountdown = 30;
    //    textMeshPro = GetComponent<TextMeshPro>();
    // }

    //public void ShowScore(int enemyCountdown)
    // {
    //     textMeshPro.text = enemyCountdown.ToString();
    // }

}
