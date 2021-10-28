using System.Collections.Generic;
using LocomotionState;
using UnityEngine;


public class LocomotionStateMachine : MonoBehaviour, IState
{
    public ILocomotionState currentState = new Grounded();
    string stateName;

    public void Crouch() => currentState.Crouch(this);

    public void Fall() => currentState.Fall(this);

    public void Jump() => currentState.Jump(this);

    public void Land() => currentState.Land(this);

    void IState.SetState<ILocomotionState>(ILocomotionState newState)
    {
        currentState = newState as global::ILocomotionState;
        SetStateName();
    }

    void SetStateName()
    {
        stateName = currentState.GetState();
    }
}
