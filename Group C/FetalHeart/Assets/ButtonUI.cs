using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string nextScene = "Main";

    public void ChangeSceneButton()
    {
        SceneManager.LoadScene(nextScene);
    }
}
