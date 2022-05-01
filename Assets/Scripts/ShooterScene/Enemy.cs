using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enemy : MonoBehaviour
{

    public ParticleSystem explosion;
    public AudioSource explosionSound;
    public AudioClip explosionSoundClip;
    [SerializeField]
    float explosionVolume = .2f;

    public void Start()
    {
        explosion = GetComponentInChildren<ParticleSystem>();
        explosionSound = GetComponent<AudioSource>();
        explosionSound.clip = explosionSoundClip;

    }

    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Projectile"))
        {
            UpdateEnemyCountdown();
           StartCoroutine(EnemyShot());
        }       
    }

    private void UpdateEnemyCountdown()
    {
        Score.enemyCountdown--;
    }

    public IEnumerator EnemyShot()
    {
        explosionSound.PlayOneShot(explosionSoundClip, .2f);
        explosion.Play();
        yield return new WaitForSeconds(.5f);
        ObjectPooler.Instance.DeactiveEnemy(gameObject);
        yield return null;
    }
}

