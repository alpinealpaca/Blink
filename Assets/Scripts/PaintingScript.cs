using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingScript : MonoBehaviour
{
    private ObjectState objectState;
    [SerializeField] private GameObject gameManager;

    [SerializeField] private int revealState;
    private bool opened = false;

    // Start is called before the first frame update
    void Start()
    {
        objectState = GetComponent<ObjectState>();
    }

    // Update is called once per frame
    void Update()
    {
        BlinkTimer blinkTimer = gameManager.GetComponent<BlinkTimer>();
        int totalBlinks = blinkTimer.totalBlinks;

        if (totalBlinks >= revealState && opened == false)
        {
            OpenPainting();
            opened = true;
        }
    }

    private void OpenPainting()
    {
        if (TryGetComponent<ContainsItem>(out ContainsItem containsItem))
        {
            containsItem.RevealItem();
        }
    }
}
