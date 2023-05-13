using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainsItem : MonoBehaviour
{
    public GameObject itemContained;
    private bool itemRevealed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RevealItem()
    {
        print("Tada! " + itemRevealed);

        if (itemRevealed == false)
        {
            itemContained.SetActive(true);
            itemRevealed = true;
        }
        
    }
}
