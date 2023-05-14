using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithItem : MonoBehaviour
{
    
    
    [SerializeField] private GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractionFunction()
    {
        if (TryGetComponent<ContainsItem>(out ContainsItem containsItem))
        {
            containsItem.RevealItem();
        }
        else if (TryGetComponent<GameWonUI>(out GameWonUI gameWonUI))
        {
            gameWonUI.Setup();
        }
        else
        {
            print("No Interaction!");
        }
    }
}
