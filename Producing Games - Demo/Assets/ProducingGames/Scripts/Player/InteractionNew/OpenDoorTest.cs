using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenDoorTest : InteractableTemplate
{
    public CameraShake cameraShake;
    public override void Interact()
    {
        Debug.Log("*** Door code is running ***");
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0,1000,0), Time.deltaTime);
        StartCoroutine(cameraShake.CamShake(1.0f, .2f));
    }
}
