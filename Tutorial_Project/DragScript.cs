using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragScript : MonoBehaviour,IBeginDragHandler, IDragHandler, IDropHandler
{
    public Image currentImage;
    public Sprite smallSprite;
    public Sprite bigSprite;
    public static Vector2 defaultposition;
    //private SpriteRenderer spriteRenderer;


    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//드래그시작.
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//드래그 중
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }


    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.Log(mousePosition.x);
        if (mousePosition.x > -1)
        {
            currentImage.sprite = bigSprite;
        }
        else
        {
            currentImage.sprite = smallSprite;
        }

        transform.Translate(mousePosition);
    }
    
    /*
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)//드래그 끝
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mousePosition;

        /****
        if (mousePosition == null)
        {
            this.transform.position = defaultposition;
        }

        else
        {
            this.transform.position = mousePosition;
            if (mousePosition.x > 7368)
            {
                spriteRenderer.sprite = BigSprite;
            }
            else
            {
                spriteRenderer.sprite = SmallSprite;
            }
        }
    }*/
}
