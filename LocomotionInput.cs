using System;
using System.Collections;
using UnityEngine;

public class LocomotionInput : MonoBehaviour
{
    [SerializeField]
    LocomotionStateMachine LSM;
    
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.J))
        {
            LSM.Jump();
            StartCoroutine(FallToGround());
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            LSM.Crouch();
        }
        
    }
    
    IEnumerator FallToGround()
    {
        yield return new WaitForSeconds(1);
        LSM.Land();
    }
}
