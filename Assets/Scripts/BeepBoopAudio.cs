using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BeepBoopAudio : MonoBehaviour
{
    public AudioClip beepBoopWelcome;
    public AudioSource beepBoopAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        beepBoopAudioSource = GetComponent<AudioSource>();
    }

    
    
    
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && !beepBoopAudioSource.isPlaying)
            {
                beepBoopAudioSource.Play();
            }
        }
        
        
        
    
}
