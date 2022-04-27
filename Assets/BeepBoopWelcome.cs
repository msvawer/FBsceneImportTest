using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeepBoopWelcome : MonoBehaviour
{
    public AudioSource beepBoopAudioSrc;
    public AudioClip beepBoopWelcome;
    public float volume = 1;

    private void Start()
    {
        beepBoopAudioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnteredBar")
        {
            //enteredBar = true;
            beepBoopAudioSrc.PlayOneShot(beepBoopWelcome, volume);
            Debug.Log("Entered Bar");
            //m_MyAudioSource.Play();
        }
    }

}