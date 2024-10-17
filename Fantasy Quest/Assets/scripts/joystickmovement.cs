using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class joystickmovement : MonoBehaviour
{

    Vector2 movevector;
    public float movespeed = 5f;

    public void Start()
    {
        Vector2 move = new Vector2(movevector.x, movevector.y);
        move.Normalize();
        transform.Translate(movespeed * move * Time.deltaTime);
    }

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
