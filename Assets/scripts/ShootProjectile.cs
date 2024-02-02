using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootProjectile : MonoBehaviour
{
    public Transform firePosition;
    public GameObject projectilePrefab;
    public float fireRate = 1.5f;
    public float launchVelocity = 5000f;

    private bool canFire = true;
    private float nextFireTime;

    private void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePosition.position, firePosition.rotation);
        projectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchVelocity);
    }

    public void OnFire(InputValue context)
    {
        if (context.isPressed)
        {
            canFire = true;
            FireProjectile(); // Fire projectile immediately when input is started
        }
        else if (context.isPressed == false)
        {
            canFire = false;
        }
    }
}