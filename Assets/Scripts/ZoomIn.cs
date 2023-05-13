using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZoomIn : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
        Debug.Log("look at this cool rotation!");
    }

    public void Leave()
    {
        //PauseScreen.gameObject.SetActive(false);

    }

}
