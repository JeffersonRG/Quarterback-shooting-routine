using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    
    // This function is called when the Collider other enters the trigger.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with has a specific tag (optional).
        if (collision.gameObject.CompareTag("shot"))
        {
            Destroy(gameObject);

            if (name.Contains("2"))
            {
                Score.Instance.AddPoint2();
            }
            else
            {
                Score.Instance.AddPoint();
            }
        }
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
            Score.hitCount++;
        }
    }
}
