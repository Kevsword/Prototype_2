using UnityEngine;

public class DetectCollisionsOP : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }

}
