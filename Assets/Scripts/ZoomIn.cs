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
        Debug.Log("Zoom!");
    }

    public void Leave()
    {
        gameObject.SetActive(false);

    }

}
