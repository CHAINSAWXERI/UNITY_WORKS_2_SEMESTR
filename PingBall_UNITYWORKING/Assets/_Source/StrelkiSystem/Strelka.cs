using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strelka : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] public KeyCode keycode;
    private bool isSpacePressed = false;

    void Update()
    {
        if (Input.GetKeyDown(keycode))
        {
            //animator.IsOn = true;
            Debug.Log("?????? ??? ?????!");
            isSpacePressed = true;
        }

        if (Input.GetKeyUp(keycode))
        {
            // ???? ??, ????????? ????????
            Debug.Log("?????? ??? ???????!");
            isSpacePressed = false;
        }
    }

}
