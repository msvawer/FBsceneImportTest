using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enemy : MonoBehaviour
{
    // [Serializable] public class HitEvent : UnityEvent<int> { }

    //public HitEvent OnHit = new HitEvent();

    private void OnCollisionEnter(Collision collision)
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
        ObjectPooler.Instance.DeactiveEnemy(gameObject);
        yield return null;
    }
}
