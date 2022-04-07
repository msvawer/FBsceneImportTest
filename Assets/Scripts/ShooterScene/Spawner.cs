using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    bool _spawnEnemies = false;

    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        
        
    }

    private void OnEnable()
    {
        EventManager.OnPlanetShot += SetTrue;
    }

    private void OnDisable()
    {
        EventManager.OnPlanetShot -= SetTrue;
    }

    public void SetTrue()
    {
        _spawnEnemies = true;
    }

    private void SpawnObject()
    {
       if (_spawnEnemies == true)
        {
            
           objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
           
        }
    }

   


    
    //IEnumerator SpawnEnemies()
    //{
     //   while (_spawnEnemies == true)
     //  {
         
     //       ObjectPooler.Instance.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
     //       yield return new WaitForSeconds(3f);
     //   }
        
    //}
}
