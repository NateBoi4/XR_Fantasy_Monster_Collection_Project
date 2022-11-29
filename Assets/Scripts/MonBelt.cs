using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MonBelt : XRBaseInteractable
{
    [SerializeField] private GameObject monBall;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        CreateAndSelectMonBall(args);
    }

    private void CreateAndSelectMonBall(SelectEnterEventArgs args)
    {
        GameObject ball = Instantiate(monBall, args.interactorObject.transform.position, 
            args.interactorObject.transform.rotation);
        XRGrabInteractable grab = ball.GetComponent<XRGrabInteractable>();
        interactionManager.SelectEnter(args.interactorObject, grab);
    }
}
