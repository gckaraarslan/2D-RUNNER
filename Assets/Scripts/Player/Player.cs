using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IState currentState;
    private Animator animator;
    private SpriteRenderer sr;


    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        currentState = new IdleState();
    }


    void Update()
    {
        currentState.UpdateState(this);
    }

    public void ChangeState(IState newState)
    {
        currentState = newState;
    }

    public void MoveAnimation()
    {
        animator.SetBool("Move", true);

        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }

    public void IdleAnimation() //bunları state'lerin içine alıcam
    {
        animator.SetBool("Move", false);
    }
}