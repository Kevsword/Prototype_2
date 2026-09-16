using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerOP : MonoBehaviour
{
    private float _horizontalMov;
    private float speed = 20.0f;
    private float xRange = 20;
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        Boundaries();

        Movement();
    }

    private void Boundaries()
    {
        // Check for left and right bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * _horizontalMov);
    }

    public void Move(InputAction.CallbackContext context)
    {
        // Player movement left to right
        _horizontalMov = context.ReadValue<Vector2>().x;
    }

    public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // No longer necessary to Instantiate prefabs
            // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            // Get an object object from the pool
            GameObject pooledProjectile = ObjectPoolerOP.SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it
                pooledProjectile.transform.position = transform.position; // position it at player
            }
        }
    }
}
