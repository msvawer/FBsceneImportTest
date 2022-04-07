using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = Random.Range(2, 10);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Time.deltaTime * enemySpeed);
    }
}
