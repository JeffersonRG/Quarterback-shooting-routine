using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceAccuracy
{
    public class ShootProjectile : MonoBehaviour
    {
        public Transform firePosition;
        public GameObject projectilePrefab;
        public float fireRate = 1.5f;
        public float launchVelocity = 5000f;
        public AudioSource audioSource;
        private bool canFire = true;
        private float nextFireTime;
        public static int shotCount = 0;

        public void Start()
        {
            shotCount = 0;
        }
        private void FireProjectile()
        {
            GameObject projectile = Instantiate(projectilePrefab, firePosition.position, firePosition.rotation);
            projectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchVelocity);
            audioSource.Play();
            shotCount++;

        }

        public void FireInput(bool newFire)
        {
            if (newFire)
            {
                canFire = true;
                FireProjectile(); // Fire projectile immediately when input is started
            }
            else if (newFire == false)
            {
                canFire = false;
            }
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
}
