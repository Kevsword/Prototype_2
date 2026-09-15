using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 25.0f;
    private float _lowerBoudn = -10.0f;

    void Update()
    {
        DeleteObjects();
    }

    private void DeleteObjects()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < _lowerBoudn)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over!");
        Destroy(gameObject);
    }
}
