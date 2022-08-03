using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    float x = 5f;
    public PlayerTestState(StateMachine stateMachine) : base(stateMachine) {    }
    public override void Enter()
    {
        Debug.Log("enter");
    }
    public override void Tick(float deltaTime)
    {
        x -= deltaTime;
        Debug.Log(x);
        if (x<=0f)
        {
            stateMachine.switchState(new PlayerTestState(stateMachine));
        }
    }
    public override void Exit()
    {
        Debug.Log("exit");
    }


}
