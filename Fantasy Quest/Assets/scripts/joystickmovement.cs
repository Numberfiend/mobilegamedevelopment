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
    public Transform gyro;
    private string controlcheck;
    public Animator joystickanim;
    public void InputPlayer(InputAction.CallbackContext _context)
    {
        movevector = _context.ReadValue<Vector2>();

    }
    public void Start()
    {
        
    }
    private void Update()
    {
       
       Vector2 move = new Vector2(movevector.x, movevector.y);
       move.Normalize();
       transform.Translate(movespeed * move * Time.deltaTime);
       gyro.transform.Translate(movespeed * move * Time.deltaTime);

        UpdateAnimations(move);
    }

    private void UpdateAnimations(Vector2 move)
    {
        if (joystickanim != null)
        {
            
            joystickanim.SetFloat("horizontal", move.x);
            joystickanim.SetFloat("vertical", move.y);

            // Determine if the character is moving
            bool isMoving = move.magnitude > 0.1f;
            joystickanim.SetBool("isMoving", isMoving);
        }
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



