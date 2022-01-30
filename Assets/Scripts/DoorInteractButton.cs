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
            float interactRadius = 5f;
            Collider[] colliderArray = Physics.OverlapSphere(playerTransform.position, interactRadius);
            foreach (Collider collider in colliderArray)
            {
                IDoor door = collider.GetComponent<IDoor>();
                if (door != null)
                { // There's a Door in  range!
                    door.ToggleDoor();
                }
            }
        }
    }
}
