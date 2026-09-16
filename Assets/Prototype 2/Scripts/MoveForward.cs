using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 10.0f;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // Lineal movement
        transform.Translate(Vector3.forward * _speed * Time.deltaTime); 
    }
}
