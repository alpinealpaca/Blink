using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using TMPro;  //for text

public class GameOverUI : MonoBehaviour
{

    public void GameOver()
    {
        gameObject.SetActive(true);
        //SomesortaScoreText.text = Score.ToString() + " Points";
        
        //Time.timeScale = 0f;

    }


    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Debug.Log("Reset");
        //Time.timeScale = 1f;
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
        //Time.timeScale = 1f;
    }
}
