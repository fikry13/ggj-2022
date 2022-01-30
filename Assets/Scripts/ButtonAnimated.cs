using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimated : MonoBehaviour, IButton
{
    private Animator animator;
    private bool isDown = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ButtonDown()
    {
        isDown = true;
        animator.SetBool("Down", true);

    }

    public void ButtonUp()
    {
        isDown = false;
        animator.SetBool("Down", false);
    }

    public void ToggleButton()
    {
        isDown = !isDown;
        if (isDown)
        {
            ButtonDown();
        }
        else
        {
            ButtonUp();
        }

    }
}
