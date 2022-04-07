using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonTrigger : MonoBehaviour
{
   // [SerializeField]
   // private GameObject myaudioGameObj;

    public AudioSource audioSource; 

    [SerializeField]
    private Animator _buttonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _buttonAnimator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            audioSource.Play();
            _buttonAnimator.SetTrigger("ButtonDown");
           
        } 
    }
    //public void SongSphereCreation()
   //{
       // if(!audioSource.isPlaying)
      //  {
           // AudioSource.Play;
       // }

       // Instantiate(myaudioGameObj);
   // }

}
