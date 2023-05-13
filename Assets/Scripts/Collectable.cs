using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    [SerializeField] private string item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // add to UI, then button in UI does this
        CursorManager cursorManager = gameManager.GetComponent<CursorManager>();
        cursorManager.SetCursor(item);


        // remove gameobject
        Destroy(gameObject);
    }
}
