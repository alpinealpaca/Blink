using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using TMPro;

public class GameWonUI : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
        //cleanCountText.text = Score.ToString() + " Points";
        //Time.timeScale = 0f;
    }


    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
        //Time.timeScale = 1f;
    }


    public void QuitButton()
    {
        Application.Quit();
        print("quit game");
    }
}
