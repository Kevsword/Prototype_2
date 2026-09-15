using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float _dogDelay = 0;

    private void Update()
    {
        if (_dogDelay > 0)
        {
            Delay();
        }
        
    }

    private void Delay()
    {
        _dogDelay -= Time.deltaTime;
    }

    public void Attack(InputAction.CallbackContext context)
    {
        if (_dogDelay <= 0)
        {
            if (context.performed)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                _dogDelay = 1.5f;
            }
        }
    }
}
