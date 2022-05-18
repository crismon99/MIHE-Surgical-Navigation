using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void SetActiveModel()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        if (txt.ToString() == "4 chamber")
        {
            txt.text = "LVOT";
        }
        else if (txt.ToString() == "LVOT")
        {
            txt.text = "RVOT";
        }
        else if (txt.ToString() == "3 vessel + trachea")
        {
            txt.text = "Full model";
        }
        else
        {
            txt.text = "4 chamber";
        }   
    }
}
