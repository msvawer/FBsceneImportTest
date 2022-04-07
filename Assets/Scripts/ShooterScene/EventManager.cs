using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void PlanetShot();
    public static event PlanetShot OnPlanetShot;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
            if (OnPlanetShot != null)
                OnPlanetShot();
    }
}
