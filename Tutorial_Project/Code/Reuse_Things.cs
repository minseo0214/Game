using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Reuse_Things : MonoBehaviour,  IDragHandler, IDropHandler
{
    public GameObject obj;
    private GameObject ins;
    
    Vector2 defaultPosition;
    // Start is called before the first frame update.
    void Start()
    {
        defaultPosition = transform.position;
        this.gameObject.SetActive(false);
    }
    public void Click_MakeImage()
    {
        this.gameObject.SetActive(true);
        ins = Instantiate(obj, obj.transform.position, obj.transform.rotation);
    }
   
    void IDragHandler.OnDrag(PointerEventData eventData)//�巡�� ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //â��
        if (mousePosition.x < -1 && mousePosition.y > 0)
        {
            Destroy(ins);
            this.gameObject.SetActive(false);
            this.transform.position = defaultPosition;
            //transform.Translate(defaultPosition);
        }
        //�ƴҶ��� �׳� �̵�
        else
        {
            transform.Translate(mousePosition);
        }
    }
}
