using System;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 15f;

    void OnEnable()
    {
        PlayerInput.OnCharacterInput += OnCharacterMove;
    }
    
    
    void OnDisable()
    {
        PlayerInput.OnCharacterInput -= OnCharacterMove;
    }
    
    public void OnCharacterMove(float horizontalInput)
    {
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        movement.x = Mathf.Clamp(movement.x * moveSpeed * Time.deltaTime, -19.2f, +9.2f);
        transform.position += movement;
    }


  
}