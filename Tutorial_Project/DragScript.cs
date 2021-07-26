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

    //우선 숫자값으로 했는데 화면 비율에 맞추도록 바꾸면 될거같아요.
    // 경계값에 있을 때 다시 돌아가게 하려고 했는데, 이미지 크기에 따라 달라서
    //이부분도 수정하시면 될듯합니다.
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log(mousePosition.y);
        //오른쪽
        if (mousePosition.x > -1)
        {
            currentImage.sprite = bigSprite;
        }
        //창문
        else if (mousePosition.x < -1 && mousePosition.y > 0)
        {
            Destroy(currentImage);
        }
        //왼쪽
        else if (mousePosition.x < -1 && mousePosition.y < 0)
        {
            currentImage.sprite = smallSprite;
        }
        //애매하면 돌아가기
        else
        {
            mousePosition = defaultposition;
        }
        transform.Translate(mousePosition);
    }
}
