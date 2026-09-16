using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Destroy item when colliding on trigger
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
