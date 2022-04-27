using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class RadioAnnouncement : MonoBehaviour
{
    public AudioSource radioSrc;
    public AudioClip radioClip;
    public AudioClip beepBoopClip;

    
    void Start()
    {
        StartCoroutine(playSound());
    }

    IEnumerator playSound()
    {
        yield return new WaitForSeconds(100);
        GetComponent<AudioSource>().clip = radioClip;
        GetComponent<AudioSource>().Play();
        
        yield return new WaitForSeconds(radioClip.length);
        GetComponent<AudioSource>().clip = beepBoopClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(beepBoopClip.length);

        
    }
}
