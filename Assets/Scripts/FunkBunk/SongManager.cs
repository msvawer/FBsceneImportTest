using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SongManager : MonoBehaviour
{
    //For XR you can attach AudioSource to Player hand
    //Add audio clips into slots in Inspector
    //Check that tags on buttons are tagged
    //Set all colliders and triggers on hand -direct interactor, sphere collider Trigger checked
    //make sure buttons have kinimatic rigid body and colliders set to trigger

    public AudioSource m_MyAudioSource;

    public AudioClip[] songArray = new AudioClip[4];


    public float volume = 1f;
    public float lowVolume = 0.1f;
    public bool enteredBar = false;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.PlayOneShot(songArray[0], lowVolume);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EnteredBar")
        {
            enteredBar = true;
            //this bool is used in BeepBoopWelcome cs 
            Debug.Log("Entered Bar");
        }

        if(other.gameObject.tag == "JB1")
        {
            m_MyAudioSource.Stop(); //Stop current song                         
            m_MyAudioSource.PlayOneShot(songArray[0], lowVolume); //Set new clip
            m_MyAudioSource.Play(); //play new clip
        }

        if(other.gameObject.tag == "JB2")
        {
            m_MyAudioSource.Stop(); 
            m_MyAudioSource.PlayOneShot(songArray[1], lowVolume);
            m_MyAudioSource.Play();
        }

        if (other.gameObject.tag == "JB3")
        {
            m_MyAudioSource.Stop(); 
            m_MyAudioSource.PlayOneShot(songArray[2], lowVolume);
            m_MyAudioSource.Play();
        }

        if (other.gameObject.tag == "JB4")
        {
            m_MyAudioSource.Stop();           
            m_MyAudioSource.PlayOneShot(songArray[3], lowVolume);
            m_MyAudioSource.Play();
        }

    }

    //void OnEnable()
    //{
      //  RadioAnnouncement.OnRadioOn += LowerVolume;
     //   RadioAnnouncement.OnBeepBoopEnd += ReturnVolume;
    //}

   // void OnDisable()
   // {
     //   RadioAnnouncement.OnRadioOn -= LowerVolume;
    //    RadioAnnouncement.OnBeepBoopEnd -= ReturnVolume;
    //}


    //void LowerVolume()
    //{
    //    m_MyAudioSource = GetComponent<AudioSource>();
     //   m_MyAudioSource.volume = lowVolume;
   // }

   // void ReturnVolume()
  //  {
     //   m_MyAudioSource = GetComponent<AudioSource>();
     //   m_MyAudioSource.volume = volume;
    //}
}
