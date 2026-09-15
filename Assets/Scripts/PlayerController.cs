using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float _horizontalMov;
    private float _speed = 20.0f;
    private float _xRange = 20;

    public GameObject projectilePrefab;

    void Update()
    {
        Boundaries();

        Movement();
    }

    private void Boundaries()
    {
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }

    private void Movement()
    {
        transform.Translate(Vector3.right * _horizontalMov * _speed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        _horizontalMov = context.ReadValue<Vector2>().x;
    }

    public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
