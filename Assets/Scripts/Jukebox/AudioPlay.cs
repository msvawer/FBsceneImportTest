using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioClip[] reggaeSongsArray = new AudioClip[4];
    public AudioSource audioSource;
    public AudioListener audioListener; 
    // Start is called before the first frame update
    void Start()
    {
        audioListener = GetComponent<AudioListener>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void onTriggerEnter()
    {
        if (!audioSource.isPlaying)
        {
            PlayRandom();
        }

        void PlayRandom()
        {
            audioSource.clip = reggaeSongsArray[Random.Range(0, reggaeSongsArray.Length)];
            audioSource.Play();


        }
    }
     }
     

