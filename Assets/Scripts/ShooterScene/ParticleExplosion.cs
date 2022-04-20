using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExplosion : MonoBehaviour
{
    [SerializeField] ParticleSystem explosion = null;
    private void Update()
    {
        ParticleSystemPlay();
    }

    public void ParticleSystemPlay()
    {
        explosion.transform.position = transform.position;

        explosion.Play();
    }
}
