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

    //재사용을 위함
    Vector2 startPosition;//처음 위치 저장
    GameObject item_make;

    private Text q;
    private RectTransform rectTran;
    private SpriteRenderer spriteRenderer;
    private int a;
    private string[] nation = {"대한민국","가나","과테말라","그리스","나이지리아","남아공","네덜란드","네팔","노르웨이","뉴질랜드","덴마크","독일","러시아","룩셈부르크","마다가스카르","말레이시아","멕시코","몰디브","몽골","미얀마","방글라데시","베네수엘라","베트남","벨기에","불가리아","브라질","사우디아라비아","수단","스리랑카","스웨덴","스위스","스페인","시리아","싱가포르","아랍에미리트","아르헨티나","아이슬란드","아이티","아일랜드","아프가니스탄","에콰도르","에티오피아","영국","오스트레일리아","오스트리아","우즈베키스탄","우크라이나","이라크","이란","이스라엘","이집트","이탈리아","인도","인도네시아","일본","자메이카","조선민주주의인민공화국","중화인민공화국","체코","칠레","카자흐스탄","캄보디아","캐나다","콜롬비아","태국","터키","포르투갈","폴란드","프랑스","핀란드","필리핀","헝가리"};

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
    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)//드래그시작.
    {
        defaultposition = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)//드래그 중
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

    //우선 숫자값으로 했는데 화면 비율에 맞추도록 바꾸면 될거같아요.
    // 경계값에 있을 때 다시 돌아가게 하려고 했는데, 이미지 크기에 따라 달라서
    //이부분도 수정하시면 될듯합니다.
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.Log(mousePosition.y);
        //오른쪽
        if (mousePosition.x > 3)
        {
            currentImage.sprite = bigSprite;
            
            rectTran.sizeDelta = new Vector2(198.0f, 277.0f);
            q.text = "입국 : 대한민국\n출국 : " + nation[a];
        }
        //창문
        else if (mousePosition.x < 3 && mousePosition.y > 0)
        {
            Destroy(ins);
            //this.gameObject.SetActive(false);
            this.transform.position = startPosition;
        }
        //왼쪽
        else if (mousePosition.x < 3 && mousePosition.y < 0)
        {
            currentImage.sprite = smallSprite;
            rectTran.sizeDelta = new Vector2(53.0f, 81.0f);
            q.text = "";
        }
        //애매하면 돌아가기
        else
        {
            mousePosition = defaultposition;
        }
        transform.Translate(mousePosition);
    }
}
