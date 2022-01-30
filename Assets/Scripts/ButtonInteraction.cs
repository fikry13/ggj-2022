using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private GameObject buttonTriggerObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Button F Pressed");
            float interactRadius = 5f;
            Collider[] colliderArray = Physics.OverlapSphere(playerTransform.position, interactRadius);
            foreach (Collider collider in colliderArray)
            {
                IButton button = collider.GetComponent<IButton>();
                if (button != null)
                {
                    button.ToggleButton();
                    buttonTriggerObject.SetActive(false);
                }
            }
        }
    }
}
