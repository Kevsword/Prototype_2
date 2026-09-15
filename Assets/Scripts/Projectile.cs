using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float _speed = 25.0f;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}