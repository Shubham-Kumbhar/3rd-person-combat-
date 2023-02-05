using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour,Controls.IPlayerActions
{
    public event Action JumpEvent;
    public event Action DodgeEvent;
    private Controls controls;
    private void Start()
    {
        controls = new Controls();
        controls.player.SetCallbacks(this);

        controls.Enable();
    }
    private void OnDestroy()
    {
        controls.Disable();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }
        JumpEvent?.Invoke();
    }
    public void OnDodge(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }

        DodgeEvent?.Invoke();
    }
}
