using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
  //Make sure to attach these Buttons in the Inspector
   // public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
//        m_YourFirstButton.onClick.AddListener(TaskOnClick);

    }


  public void ButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

