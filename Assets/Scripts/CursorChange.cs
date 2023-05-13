using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorTexture; // The texture to use for the cursor when hovering over the button
    //public Vector2 cursorHotspot; // The hotspot of the cursor texture 
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 hotspot = new Vector2(rectTransform.rect.width * rectTransform.pivot.x, rectTransform.rect.height * rectTransform.pivot.y);
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto); //hotspot. Vector2.zero sets hotspot to top left corner of texture
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
