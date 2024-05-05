using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimitor : MonoBehaviour
{
    [SerializeField] private InputActionProperty TriggerAction;
    [SerializeField] private InputActionProperty griptAction;

    private Animator anim;

    
    private void Update()
    {
        float triggerValue = TriggerAction.action.ReadValue<float>();
        float gripValu = griptAction.action.ReadValue<float>();

        anim.SetFloat("Trigger" , triggerValue);
        anim.SetFloat("Grip" , gripValu);   

    }

}
