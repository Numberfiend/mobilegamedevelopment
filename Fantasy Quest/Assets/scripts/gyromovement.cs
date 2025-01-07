using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class gyromovement : MonoBehaviour
{
    public float movespeed = 5.0f;
    Vector2 movevector;
    public Rigidbody rb;
    public Transform joystick;
    // Start is called before the first frame update
    void Start()
    {
        
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        Input.gyro.enabled = true;
        Debug.Log(Input.acceleration);
        if (Input.acceleration.x >= 0.4f)
        {
            Vector2 move = new Vector2(1, 0);
            transform.Translate(move * movespeed * Time.deltaTime);
            joystick.transform.Translate(move * movespeed * Time.deltaTime);
        }

        if (Input.acceleration.x <= -0.4f)
        {
            Vector2 move = new Vector2(-1, 0);
            transform.Translate(move * movespeed * Time.deltaTime);
            joystick.transform.Translate(move * movespeed * Time.deltaTime);
        }

        if (Input.acceleration.y >= 0.4f)
        {
            Vector2 move = new Vector2(0, 1);
            transform.Translate(move * movespeed * Time.deltaTime);
            joystick.transform.Translate(move * movespeed * Time.deltaTime);
        }

        if (Input.acceleration.y <= -0.4f)
        {
            Vector2 move = new Vector2(0, -1);
            transform.Translate(move * movespeed * Time.deltaTime);
            joystick.transform.Translate(move * movespeed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("level1"))
        {
            Debug.Log("Collided with: " + collision.gameObject.name);
            SceneManager.LoadScene("RandomBattleMap");

        }

        if (collision.gameObject.CompareTag("level2"))
        {
            Debug.Log("Collided with: " + collision.gameObject.name);
            SceneManager.LoadScene("RandomBattleMap");

        }

        if (collision.gameObject.CompareTag("level3"))
        {
            Debug.Log("Collided with: " + collision.gameObject.name);
            SceneManager.LoadScene("RandomBattleMap");

        }

        if (collision.gameObject.CompareTag("level4"))
        {
            Debug.Log("Collided with: " + collision.gameObject.name);
            SceneManager.LoadScene("RandomBattleMap");

        }

    }
}
