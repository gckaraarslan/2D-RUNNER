using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    
    
    // public void EnterState(Player player)
    // {
    //     Debug.Log("Entering To The MoveState");
    // }

    public void UpdateState(Player player)
    {
        if (Input.GetAxis("Horizontal")==0)
        {
            player.ChangeState(new IdleState());
            player.IdleAnimation();
        }
    }

    // public void ExitState(Player player)
    // {
    //     Debug.Log("Exiting From The MoveState ");
    // }
}
