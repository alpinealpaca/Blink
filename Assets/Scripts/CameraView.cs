using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class CameraView : MonoBehaviour
{
    public Transform target;
    public float speed;

    private Vector3 offset;
    private Quaternion targetRotation = Quaternion.identity;
    private bool rotating = false;

    //[SerializeField] private 

    void Update()
     {
        if (rotating == true)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, speed * Time.deltaTime);

            if (transform.rotation == targetRotation)
            {
                rotating = false;
            }

            //Debug.Log("look at this cool rotation!");
        }

        
    }

    public void RightArrow()
    {
        //start
        offset = transform.position - target.position;
        targetRotation *= Quaternion.Euler(0, 90, 0);

        rotating = true;
    }

    public void LeftArrow()
    {
        offset = transform.position - target.position;
        targetRotation *= Quaternion.Euler(0, -90, 0);

        rotating = true;
    }


}
