using UnityEngine;

public class IdleState :IState
{
    // public void EnterState(Player player)
    // {
    //     Debug.Log("Entering To The IdleState");
    // }

    public void UpdateState(Player player)
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            player.ChangeState(new MoveState());
            player.MoveAnimation();  
        }
    }

    // public void ExitState(Player player)
    // {
    //     Debug.Log("Exiting From The IdleState");
    //    
    // }
}