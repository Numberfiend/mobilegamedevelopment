using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputManager : MonoBehaviour
{
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnStartTouch;
    public delegate void EndTouchEvent(Vector2 position, float time);
    public event EndTouchEvent OnEndTouch;

    private Inputsystems touchControls;

    private void Awake()
    {
        touchControls = new Inputsystems();
    }

    private void OnEnable()
    {
        touchControls.Enable();    
    }
    private void OnDisable()
    {
        touchControls.Disable();
    }

    private void Start()
    {
        touchControls.Touch.touchpress.started += ctx => StartTouch(ctx);
        touchControls.Touch.touchpress.canceled += ctx => EndTouch(ctx);
    }
    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("TouchStarted" + touchControls.Touch.touchposition.ReadValue<Vector2>());
        if (OnStartTouch != null)
        {
            OnStartTouch(touchControls.Touch.touchposition.ReadValue<Vector2>(), (float)context.startTime);
        }
    }
    private void EndTouch(InputAction.CallbackContext context)
    {
        if (OnEndTouch != null)
        {
            OnEndTouch(touchControls.Touch.touchposition.ReadValue<Vector2>(), (float)context.time);
        }
    }
}
