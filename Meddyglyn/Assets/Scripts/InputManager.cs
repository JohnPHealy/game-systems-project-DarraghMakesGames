using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }
    private PlayerControls playerControls;

    //The following defines playerControls, and helper functions that allow other scripts to enable & disable the player controls

    private void Awake()
    {

        //Code to check if InputManager exists already & Destroy this if it is, otherwise define _instance as this
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } 
        else
        {
            _instance = this;
        }
        
        playerControls = new PlayerControls();
        Cursor.visible = false;

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    //Functions for player movements

    public Vector2 getPlayerMovement()
    {
        return playerControls.DefaultPlayer.Movement.ReadValue<Vector2>();
    }

    public Vector2 getMouseDelta()
    {
        return playerControls.DefaultPlayer.Look.ReadValue<Vector2>();
    }

    public bool PlayerJumped()
    {
        return playerControls.DefaultPlayer.Jump.triggered;
    }

}
