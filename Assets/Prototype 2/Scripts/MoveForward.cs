using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 10.0f;

    private PlayerControllerOP _playerControllerScript;

    private void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerOP>();
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // Lineal movement
        if (_playerControllerScript.HasLives)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
