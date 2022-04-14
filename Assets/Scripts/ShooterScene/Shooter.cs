using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooter : MonoBehaviour
{
    public float recoil = 1.0f;
    public Transform barrel = null;
    public GameObject projectilePrefab = null;

    private XRGrabInteractable interactable = null;

    private Rigidbody rigidBody = null;

    [SerializeField]
    private AudioSource shooterNoiseSource;

    [SerializeField]
    private AudioClip shooterNoiseClip;

    [SerializeField]
    private float volume = 0.5f;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        rigidBody = GetComponent<Rigidbody>();
        shooterNoiseSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        interactable.onActivate.AddListener(Fire);

    }

    private void OnDisable()
    {
        interactable.onDeactivate.RemoveListener(Fire);
    }

    private void Fire(XRBaseInteractor interactor)
    {
        CreateProjectile();
        print("Fire");
        ApplyRecoil();
        ShootNoise();
    }

    private void ShootNoise()
    {
        shooterNoiseSource.PlayOneShot(shooterNoiseClip, volume);
    }

    private void CreateProjectile()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, barrel.position, barrel.rotation);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch();
    }
        
    private void ApplyRecoil()
    {
        rigidBody.AddRelativeForce(Vector3.back * recoil, ForceMode.Impulse);
    }
}