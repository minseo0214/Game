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


    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//�巡�׽���.
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//�巡�� ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    //�켱 ���ڰ����� �ߴµ� ȭ�� ������ ���ߵ��� �ٲٸ� �ɰŰ��ƿ�.
    // ��谪�� ���� �� �ٽ� ���ư��� �Ϸ��� �ߴµ�, �̹��� ũ�⿡ ���� �޶�
    //�̺κе� �����Ͻø� �ɵ��մϴ�.
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log(mousePosition.y);
        //������
        if (mousePosition.x > -1)
        {
            currentImage.sprite = bigSprite;
        }
        //â��
        else if (mousePosition.x < -1 && mousePosition.y > 0)
        {
            Destroy(currentImage);
        }
        //����
        else if (mousePosition.x < -1 && mousePosition.y < 0)
        {
            currentImage.sprite = smallSprite;
        }
        //�ָ��ϸ� ���ư���
        else
        {
            mousePosition = defaultposition;
        }
        transform.Translate(mousePosition);
    }
}
