using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationRoller : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCol2D;

    public int rollerState = 0;
    [SerializeField] private int rollerMax;
    [SerializeField] private Sprite[] spriteArray;

    // Start is called before the first frame update
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCol2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        rollerState += 1;

        if (rollerState > rollerMax)
        {
            rollerState = 0;
        }
        print(rollerState);

        spriteRenderer.sprite = spriteArray[rollerState];
    }
}
