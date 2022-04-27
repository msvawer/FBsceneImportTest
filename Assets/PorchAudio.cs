using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorchAudio : MonoBehaviour
{
    public AudioSource porchDialogue;
    SongManager songManager;
    public GameObject SongObj;

    // Start is called before the first frame update
    void Start()
    {
        porchDialogue = GetComponent<AudioSource>();
        songManager = SongObj.GetComponent<SongManager>();
    }

    private void Update()
    {
        //uses bool from SongManager to stop the porch Dialogue 
        if (songManager.enteredBar)
        {
            porchDialogue.Stop();
        }
    }
}
