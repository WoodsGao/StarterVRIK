using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit.Inputs;


public class XRSimpleInputManager : MonoBehaviour
{
    public VRIKLocomotionController Controller;

    public void OnIKMove(InputValue input)
    {
        Vector2 move = input.Get<Vector2>();
        Debug.Log("move: " + move);
        Controller.Movement = move;
    }
    public void OnIKJump()
    {
        Debug.Log("jump");
        Controller.Jump = true;
    }
    public void OnIKSprint(InputValue input)
    {
        Debug.Log("sprint");
        Controller.Sprint = input.Get<float>() > 0.5f;
    }
}
