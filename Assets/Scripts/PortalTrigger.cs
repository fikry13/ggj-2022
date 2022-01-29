using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{

    public LevelManager levelManager;

    void OnTriggerEnter()
    {
        //Debug.Log("Enter portal");
        levelManager.CompleteLevel();
    }
}
