using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    [SerializeField] private Material myMaterial1;
    [SerializeField] private Material myMaterial2;
    [SerializeField] private Material myMaterial3;
    [SerializeField] private Material myMaterial4;

    private void Start()
    {
        Color color1 = myMaterial1.color;
        color1.a = 0.5f;
        myMaterial1.color = color1;

        Color color2 = myMaterial2.color;
        color2.a = 0.5f;
        myMaterial2.color = color2;

        Color color3 = myMaterial3.color;
        color3.a = 0.5f;
        myMaterial3.color = color3;

        Color color4 = myMaterial4.color;
        color4.a = 0.5f;
        myMaterial4.color = color4;
    }

    public void AlphaSlider(float sliderValue)
    {
        Color color1 = myMaterial1.color;
        color1.a = sliderValue;
        myMaterial1.color = color1;

        Color color2 = myMaterial2.color;
        color2.a = sliderValue;
        myMaterial2.color = color2;

        Color color3 = myMaterial3.color;
        color3.a = sliderValue;
        myMaterial3.color = color3;

        Color color4 = myMaterial4.color;
        color4.a = sliderValue;
        myMaterial4.color = color4;
    }
}
