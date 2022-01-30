using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Button E Pressed");
            float interactRadius = 10f;
            Collider[] colliderArray = Physics.OverlapSphere(playerTransform.position, interactRadius);
            foreach (Collider collider in colliderArray)
            {
                //IButton button = collider.GetComponent<IButton>();
                //if (button != null)
                //{   // Button in range
                //    Debug.Log("Toggle Door button");
                //    button.ToggleButtonDoor();
                //}
                IDoor door = collider.GetComponent<IDoor>();
                if (door != null)
                { // There's a Door in  range!
                    door.ToggleDoor();
                }
            }
        }
    }
}
