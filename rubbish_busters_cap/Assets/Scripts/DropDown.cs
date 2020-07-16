using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void HandleInputData(int val = 0)
    {
        if (val == 0)
        {
            GlobalData.dropDownNr = val;
            Debug.Log(GlobalData.dropDownNr);

            output.text = "Welcome to Seattle Rubbish Busters";
        }
        else if (val == 1)
        {
            GlobalData.dropDownNr = val;
            Debug.Log(GlobalData.dropDownNr);
            output.text = "Welcome to New York Rubbish Busters";
        }
    }
}