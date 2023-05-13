using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectState : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressState(int blinkNum)
    {
        spriteRenderer.sprite = spriteArray[blinkNum];
    }

}
