using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    [SerializeField] private string item;
    [SerializeField] private GameObject button;

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
        button.SetActive(true);
        //CursorManager cursorManager = gameManager.GetComponent<CursorManager>();
        //cursorManager.SetCursor(item);


        // remove gameobject
        Destroy(gameObject);
    }
}
