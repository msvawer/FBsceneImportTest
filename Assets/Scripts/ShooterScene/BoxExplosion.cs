using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExplosion : MonoBehaviour
{
    public ParticleSystem explosionPS;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Trigger entered");
            explosionPS.Play();
        }
            
    }

}
