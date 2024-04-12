using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strelka : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode keycode;

    private bool isKeyPressed = false;

    void Update()
    {
        if (Input.GetKeyDown(keycode) && !isKeyPressed)
        {
            Debug.Log("BOO!");
            animator.SetBool("IsUp", true);
            isKeyPressed = true;
        }
        else if (Input.GetKeyUp(keycode) && isKeyPressed)
        {
            animator.SetBool("IsUp", false);
            isKeyPressed = false;
        }
    }
}

