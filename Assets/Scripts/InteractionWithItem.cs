using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithItem : MonoBehaviour
{
    private ObjectState objectState;
    
    [SerializeField] private GameObject gameManager;
    [SerializeField] private Sprite[] newSpriteArray;
    [SerializeField] private string item;
    
    // Start is called before the first frame update
    void Start()
    {
        objectState = GetComponent<ObjectState>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        CursorManager cursorManager = gameManager.GetComponent<CursorManager>();
         string cursorState = cursorManager.cursorState;

        if (cursorState == item)
        {
            InteractionFunction();

            cursorManager.SetCursor("");
        }

    }

    private void InteractionFunction()
    {
        print("Interaction!");
        objectState.spriteArray = newSpriteArray;

        BlinkTimer blinkTimer = gameManager.GetComponent<BlinkTimer>();
        int totalBlinks = blinkTimer.totalBlinks;
        objectState.ProgressState(totalBlinks);

        if (TryGetComponent<ContainsItem>(out ContainsItem containsItem))
        {
            containsItem.RevealItem();
        }
        
    }

}
