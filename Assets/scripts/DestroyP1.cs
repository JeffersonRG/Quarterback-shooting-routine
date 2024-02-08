using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // This function is called when the Collider other enters the trigger.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with has a specific tag (optional).
        if (collision.gameObject)
        {
            Destroy(gameObject);

            Score.Instance.AddPoint();
        }
    }
}
