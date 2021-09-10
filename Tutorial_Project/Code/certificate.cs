using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class certificate : MonoBehaviour, IBeginDragHandler, IDragHandler, IDropHandler
{
    public Image currentImage;
    public Sprite smallSprite;
    public Sprite bigSprite;

    public GameObject obj;
    private GameObject ins;

    public static Vector2 defaultposition;

    //������ ����
    Vector2 startPosition;//ó�� ��ġ ����
    GameObject item_make;

    private Text q;
    private RectTransform rectTran;
    private SpriteRenderer spriteRenderer;
    private int a;
    private string[] nation = {"���ѹα�","����","���׸���","�׸���","����������","���ư�","�״�����","����","�븣����","��������","����ũ","����","���þ�","����θ�ũ","���ٰ���ī��","�����̽þ�","�߽���","�����","����","�̾Ḷ","��۶󵥽�","���׼�����","��Ʈ��","���⿡","�Ұ�����","�����","����ƶ���","����","������ī","������","������","������","�ø���","�̰�����","�ƶ����̸�Ʈ","�Ƹ���Ƽ��","���̽�����","����Ƽ","���Ϸ���","�������Ͻ�ź","���⵵��","��Ƽ���Ǿ�","����","����Ʈ���ϸ���","����Ʈ����","���Ű��ź","��ũ���̳�","�̶�ũ","�̶�","�̽���","����Ʈ","��Ż����","�ε�","�ε��׽þ�","�Ϻ�","�ڸ���ī","�������������ιΰ�ȭ��","��ȭ�ιΰ�ȭ��","ü��","ĥ��","ī���彺ź","į�����","ĳ����","�ݷҺ��","�±�","��Ű","��������","������","������","�ɶ���","�ʸ���","�밡��"};

    public void Click_MakeImage()
    {
        this.gameObject.SetActive(true);
        ins = Instantiate(obj, obj.transform.position, obj.transform.rotation);
    }

    void Start()
    {
        startPosition = transform.position;
        q = GameObject.Find("certificateText1").GetComponent<Text>();
        rectTran = GetComponent<RectTransform>();
        this.gameObject.SetActive(false);
    }
    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//�巡�׽���.
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//�巡�� ��
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }
    void Update()
    {
        /*
        if(Inspected.checkCertificate == 1)
        {
            Debug.Log(Inspected.checkCertificate);
            transform.position = new Vector2(200.0f, 100.0f);
            Inspected.checkCertificate = 0;
            a = Random.Range(0, 73);

        }*/
        
    }

    //�켱 ���ڰ����� �ߴµ� ȭ�� ������ ���ߵ��� �ٲٸ� �ɰŰ��ƿ�.
    // ��谪�� ���� �� �ٽ� ���ư��� �Ϸ��� �ߴµ�, �̹��� ũ�⿡ ���� �޶�
    //�̺κе� �����Ͻø� �ɵ��մϴ�.
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.Log(mousePosition.y);
        //������
        if (mousePosition.x > 3)
        {
            currentImage.sprite = bigSprite;
            
            rectTran.sizeDelta = new Vector2(198.0f, 277.0f);
            q.text = "�Ա� : ���ѹα�\n�ⱹ : " + nation[a];
        }
        //â��
        else if (mousePosition.x < 3 && mousePosition.y > 0)
        {
            Destroy(ins);
            //this.gameObject.SetActive(false);
            this.transform.position = startPosition;
        }
        //����
        else if (mousePosition.x < 3 && mousePosition.y < 0)
        {
            currentImage.sprite = smallSprite;
            rectTran.sizeDelta = new Vector2(53.0f, 81.0f);
            q.text = "";
        }
        //�ָ��ϸ� ���ư���
        else
        {
            mousePosition = defaultposition;
        }
        transform.Translate(mousePosition);
    }
}
