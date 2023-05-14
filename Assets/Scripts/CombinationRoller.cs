using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinationRoller : MonoBehaviour
{
    private Image image;
    private BoxCollider2D boxCol2D;

    public int rollerState = 0;
    [SerializeField] private int rollerMax;
    [SerializeField] private Sprite[] spriteArray;

    // Start is called before the first frame update
    private void Start()
    {
        image = GetComponent<Image>();
        boxCol2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roll()
    {
        rollerState += 1;

        if (rollerState > rollerMax)
        {
            rollerState = 0;
        }
        print(rollerState);

        image.sprite = spriteArray[rollerState];
    }
}
