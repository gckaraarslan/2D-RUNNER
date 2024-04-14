using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  
    public static event Action<float> OnCharacterInput;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        OnCharacterInput?.Invoke(horizontalInput);
    }

  
}
