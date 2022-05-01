using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enemy : MonoBehaviour
{

    public ParticleSystem explosion;

    public void Start()
    {
        explosion = GetComponentInChildren<ParticleSystem>();
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
        explosion.Play();
        yield return new WaitForSeconds(3);
        ObjectPooler.Instance.DeactiveEnemy(gameObject);
        yield return null;
    }
}

