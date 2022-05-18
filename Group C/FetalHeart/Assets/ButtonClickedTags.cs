using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClickedTags : MonoBehaviour
{
    public Text Textfield;
    public GameObject chambersTags;
    public GameObject LVOTTags;
    public GameObject RVOTTags;
    public GameObject vesselsTags;
    public TextMeshProUGUI buttonTagsText;

    private void Start()
    {
        chambersTags.SetActive(false);
        LVOTTags.SetActive(false);
        RVOTTags.SetActive(false);
        vesselsTags.SetActive(false);
    }

    public void SetActiveTags()
    {
        if (buttonTagsText.text == "Hide tags")
        {
            chambersTags.SetActive(false);
            LVOTTags.SetActive(false);
            RVOTTags.SetActive(false);
            vesselsTags.SetActive(false);
         
            buttonTagsText.text = "Show tags";
        }

        else
        {
            if (Textfield.text == "4 chambers")
            {
                chambersTags.SetActive(true);
            }
            else if (Textfield.text == "LVOT")
            {
                LVOTTags.SetActive(true);
            }
            else if (Textfield.text == "RVOT")
            {
                RVOTTags.SetActive(true);
            }
            else if (Textfield.text == "3 vessels + trachea")
            {
                vesselsTags.SetActive(true);
            }
            buttonTagsText.text = "Hide tags";
        }
    }
}