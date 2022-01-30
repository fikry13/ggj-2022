using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour, IDoor
{
    public enum ColorName
    {
        Green,
        Red,
        Blue,
    }

    private Animator doorAnimator;

    private void Awake()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        doorAnimator.SetBool("Open", true);
    }

    public void CloseDoor()
    {
        doorAnimator.SetBool("Open", false);
    }

    public void PlayOpenFailAnim()
    {
        doorAnimator.SetTrigger("OpenFail");
    }

    public void ToggleDoor()
    {
        throw new System.NotImplementedException();
    }
}
