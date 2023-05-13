using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoShowcase : MonoBehaviour
{
    [SerializeField] private GameObject zoominObject;

    void OnMouseDown()
    {
        ZoomIn zoomin = zoominObject.GetComponent<ZoomIn>();
        zoomin.Setup();
        
    }



    
}
