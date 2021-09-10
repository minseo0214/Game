using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCardID : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Image image;
    public Sprite Small;
    public Sprite Large;
    public static Vector2 defaultPosition; // 처음 위치
    public static Vector2 startPosition;//시작위치
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//드래그시작할 때

    {
        defaultPosition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//드래그 중
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)//드래그 끝
    {

        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        //Debug.Log(currentPos.x);
        if (currentPos.x > 340) // 옆에 나무 창일 때
        {
            image.sprite = Large;
            RectTransform rectTran = this.GetComponent<RectTransform>();
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 710);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
            IDrandName.IDcheck = 1;
        }
        else if (currentPos.x < 270)
        {
            image.sprite = Small;
            RectTransform rectTran = this.GetComponent<RectTransform>();
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 340);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
            IDrandName.IDcheck = 0;
        }
    }

    //버튼 클릭시 작은 상태로 돌아오기
    public void clickToSmall()
    {
        image.sprite = Small;
        RectTransform rectTran = this.GetComponent<RectTransform>();
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 340);
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
        this.transform.position = startPosition;
        IDrandName.IDcheck = 0;
    }
}
