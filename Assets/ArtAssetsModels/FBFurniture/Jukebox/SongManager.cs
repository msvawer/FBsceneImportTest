using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SongManager : MonoBehaviour
{
    //For XR attach AudioSource to Player hand
    //Add audio clips into slots in Inspector
    //Check that tags on buttons are tagged
    //Set all colliders and triggers on hand -direct interactor, sphere collider Trigger checked
    //make sure buttons have kinimatic rigid body and colliders set to trigger

    public AudioSource m_MyAudioSource;

    public AudioClip song1;
    public AudioClip song2;
    public AudioClip song3;
    public AudioClip song4;

    public float volume = 1f;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "JB1")
        {
            m_MyAudioSource.Stop(); //Stop current song                         
            m_MyAudioSource.PlayOneShot(song1, volume); //Set new clip
            m_MyAudioSource.Play(); //play new clip
        }

        if(other.gameObject.tag == "JB2")
        {
            m_MyAudioSource.Stop(); 
            m_MyAudioSource.PlayOneShot(song2, volume);
            m_MyAudioSource.Play();
        }

        if (other.gameObject.tag == "JB3")
        {
            m_MyAudioSource.Stop(); 
            m_MyAudioSource.PlayOneShot(song3, volume);
            m_MyAudioSource.Play();
        }

        if (other.gameObject.tag == "JB4")
        {
            m_MyAudioSource.Stop();           
            m_MyAudioSource.PlayOneShot(song4, volume);
            m_MyAudioSource.Play();
        }
    }
}
