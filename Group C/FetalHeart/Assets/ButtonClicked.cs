using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClicked : MonoBehaviour
{
    public Text Textfield;
    public GameObject FullModel;
    public GameObject chambersModel;
    public GameObject LVOTModel;
    public GameObject RVOTModel;
    public GameObject vesselsModel;
    public GameObject chamberImage;
    public GameObject RVOTImage;
    public GameObject LVOTImage;
    public GameObject vesselsImage;

    public TextMeshProUGUI buttonTagsText;
    public GameObject chambersTags;
    public GameObject LVOTTags;
    public GameObject RVOTTags;
    public GameObject vesselsTags;

    public void SetActiveModel()
    {   
        if (Textfield.text == "Full model")
        {
            Textfield.text = "4 chambers";
            FullModel.SetActive(false);
            chambersModel.SetActive(true);
            chamberImage.SetActive(true);
            
            if(buttonTagsText.text == "Hide tags")
            {
                chambersTags.SetActive(true);
            }
        }
        else if (Textfield.text == "4 chambers")
        {
            Textfield.text = "LVOT";
            chambersModel.SetActive(false);
            chamberImage.SetActive(false);
            chambersTags.SetActive(false);
            LVOTModel.SetActive(true);
            LVOTImage.SetActive(true);

            if(buttonTagsText.text == "Hide tags")
            {
                LVOTTags.SetActive(true);
            }
        }
        else if (Textfield.text == "LVOT")
        {
            Textfield.text = "RVOT";
            LVOTModel.SetActive(false);
            LVOTImage.SetActive(false);
            LVOTTags.SetActive(false);
            RVOTModel.SetActive(true);
            RVOTImage.SetActive(true);

            if(buttonTagsText.text == "Hide tags")
            {
                RVOTTags.SetActive(true);
            }
        }
        else if (Textfield.text == "RVOT")
        {
            Textfield.text = "3 vessels + trachea";
            RVOTModel.SetActive(false);
            RVOTImage.SetActive(false);
            LVOTTags.SetActive(false);
            vesselsModel.SetActive(true);
            vesselsImage.SetActive(true);

            if(buttonTagsText.text == "Hide tags")
            {
                vesselsTags.SetActive(true);
            }
        }
        else
        {
            Textfield.text = "Full model";
            vesselsModel.SetActive(false);
            vesselsImage.SetActive(false);
            vesselsTags.SetActive(false);
            FullModel.SetActive(true);
        }   
        
    }
}
