using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private string input;
    private bool toggleButton = false;

    public InputHandler(string inputString)
    {
        input = inputString;
    }

    public bool InputIsToggled()
    {
        if (Input.GetAxis(input) > 0 && !toggleButton)
        {
            toggleButton = true;
            return true;
        }

        if (Input.GetAxis(input) == 0)
        {
            toggleButton = false;
        }

        return false;
    }

}
