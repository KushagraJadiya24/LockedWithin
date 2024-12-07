using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class UI_InputScript : MonoBehaviour
{
    [SerializeField] InputField inputField;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ValidateInput()
    {
        string input = inputField.text;

        if (input  == "Lamp")
        {
            LoadScene("End");
        }
        else 
        {
            LoadScene("doorEnd");
        }


    }

}
