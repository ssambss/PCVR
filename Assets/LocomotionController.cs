using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTPRay;
    public XRController rightTPRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    public bool enableLeftTeleport { get; set; } = true;
    public bool enableRightTeleport { get; set; } = true;


    void Update()
    {
        if (leftTPRay)
        {
            leftTPRay.gameObject.SetActive(enableLeftTeleport && CheckIfActivated(leftTPRay));
        }

        if (rightTPRay)
        {
            rightTPRay.gameObject.SetActive(enableRightTeleport && CheckIfActivated(rightTPRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}