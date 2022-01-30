using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField]
    private GameObject doorAnimatedGameObject;

    private IDoor doorAnimated;

    private void Awake()
    {
        doorAnimated = doorAnimatedGameObject.GetComponent<IDoor>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            doorAnimated.OpenDoor();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            doorAnimated.CloseDoor();
        }
    }
}
