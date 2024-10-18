using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class joystickmovement : MonoBehaviour
{

    Vector2 movevector;
    public float movespeed = 5f;
    public Rigidbody rb;

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

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("levelintro"))
        {
            Debug.Log("Collided with: " + collision.gameObject.name);
            SceneManager.LoadScene("RandomBattleMap");

        }
        
    }
}



