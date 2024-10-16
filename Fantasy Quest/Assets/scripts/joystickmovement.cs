using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class joystickmovement : MonoBehaviour
{

    Vector2 movevector;
    public float movespeed = 1f;

    public void InputPlayer(InputAction.CallbackContext _context)
    {
        movevector = _context.ReadValue<Vector2>();

    }

    private void Update()
    {
        Vector2 move = new Vector2(movevector.x, movevector.y);
        move.Normalize();
        transform.Translate(movespeed * move * Time.deltaTime);
    }
}
