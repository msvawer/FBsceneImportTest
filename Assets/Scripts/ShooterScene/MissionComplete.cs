using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionComplete : MonoBehaviour
{

    public AudioSource missionCompleteAudio;
    // Start is called before the first frame update
    void Start()
    {
        missionCompleteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.enemyCountdown == 0)
        {
            Debug.Log("==0 is true");
            MissionCompleted();
        }
    }

    public void MissionCompleted()
    {

        missionCompleteAudio.Play();
    }
}
