using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCardCF : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Image image;
    public Sprite Small;
    public Sprite Large;
    public static Vector2 defaultPosition;
    public static Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//�巡�׽����� ��

    {
        defaultPosition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//�巡�� ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)//�巡�� ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        //Debug.Log(currentPos.x);
        if (currentPos.x > 340) // ���� ���� â�� ��
        {
            image.sprite = Large;
            RectTransform rectTran = this.GetComponent<RectTransform>();
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 320);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
            randName.check = 1;
        }
        else if (currentPos.x < 270)
        {
            image.sprite = Small;
            RectTransform rectTran = this.GetComponent<RectTransform>();
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 160);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
            randName.check = 0;
        }
    }

    public void clickToSmall()//��ư���� �����
    {
        image.sprite = Small;
        RectTransform rectTran = this.GetComponent<RectTransform>();
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 160);
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
        this.transform.position = startPosition;
        randName.check = 0;
    }
}
