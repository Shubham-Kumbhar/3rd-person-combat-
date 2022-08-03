using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{

    private State currentState;

    // Update is called once per frame
    void Update()
    {
        currentState?.Tick(Time.deltaTime);// ? check if curret state is not null if its not null then execute the tick method

    }
    public void switchState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();

    }
}
