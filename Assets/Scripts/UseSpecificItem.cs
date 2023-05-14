using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSpecificItem : MonoBehaviour
{
    private ObjectState objectState;
    private InteractionWithItem interactionWithItem;

    [SerializeField] private GameObject gameManager;
    [SerializeField] private string item;

    [SerializeField] private Sprite[] newSpriteArray;

    // Start is called before the first frame update
    void Start()
    {

        objectState = GetComponent<ObjectState>();
        interactionWithItem = GetComponent<InteractionWithItem>();
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
            objectState.spriteArray = newSpriteArray;

            BlinkTimer blinkTimer = gameManager.GetComponent<BlinkTimer>();
            int totalBlinks = blinkTimer.totalBlinks;
            objectState.ProgressState(totalBlinks);


            interactionWithItem.InteractionFunction();

            cursorManager.SetCursor("");
        }

    }
}
