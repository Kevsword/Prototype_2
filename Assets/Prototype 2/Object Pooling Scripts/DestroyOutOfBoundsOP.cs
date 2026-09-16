using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsOP : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    private PlayerControllerOP _playerControllerScript;

    private void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerOP>();
    }

    void Update()
    {
        DeleteObjects();
    }

    private void DeleteObjects()
    {
        // When projectile reaches top bound deactivate it
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }

        // Animal reaches lower bound
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            _playerControllerScript.LifeDown();
            if (_playerControllerScript.Lives <= 0)
            {
                _playerControllerScript.GameOver();
            }

            Destroy(gameObject);
        }
    }
}
