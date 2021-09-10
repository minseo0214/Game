using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoStart : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Button Access, Reject;

    public GameObject correct;
    public GameObject wrong;

    public GameObject nomask;//마스크 미착용
    public GameObject nose;//콧물
    public GameObject mouse;//입
    public GameObject fever;//열
    public GameObject ID;//신원

    public GameObject itemID;
    public GameObject itemCF;

    Vector3 target;
    Vector3 endtarget;
    Vector3 StartingPoint;

    bool check = true;
    bool flag_a = false;
    bool flag_r = false;
    bool mask = true;

    bool act = true;
    Button btnA;
    Button btnR;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartingPoint = transform.position;//처음의 위치값 저장
        target = GameObject.Find("Window").transform.position;
        endtarget = GameObject.Find("Window").transform.position;
        target.y = StartingPoint.y;
        endtarget.y = StartingPoint.y;
        endtarget.x = 2 * target.x;

        Access.onClick.AddListener(access);
        Reject.onClick.AddListener(reject);

        //버튼을 비활성화 시키기 위해
        btnA = GameObject.Find("btnAccess").GetComponent<Button>();
        btnR = GameObject.Find("btnReject").GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x);
        //처음 움직일 때
        if (check)
        {
            if (mask)//마스크를 한 번만 쓰기 위함.
            {
                GameObject.Find("item").GetComponent<RandomMask>().Appear();
                GameObject.Find("item").GetComponent<RandNameCheck>().GetIndex();
                mask = false;
            }

            rb.transform.position = Vector3.MoveTowards(transform.position, target, speed);
            if (transform.position.x == target.x)
            {
                check = false;
                //중앙에 왔을 때 버튼 활성화
                btnA.interactable = true;
                btnR.interactable = true;

                //다시 활성화
                itemCF.SetActive(true);
                itemID.SetActive(true);
            }
            
            
        }
        else if(flag_a)//출입허가를 받았을 때, 오른쪽으로 가자.
        {
            //버튼이 클릭되었을 때, 버튼 비활성화
            btnA.interactable = false;
            btnR.interactable = false;


            //증명서들 비활성화
            if (act)
            {
                itemCF.SetActive(false);
                itemID.SetActive(false);
                act = false;
            }

            rb.transform.position = Vector3.MoveTowards(transform.position, endtarget, speed);
            if (transform.position.x == endtarget.x)
            {
                transform.position = StartingPoint;//원래 위치로
                wrong.SetActive(false);
                correct.SetActive(false);

                nomask.SetActive(false);
                nose.SetActive(false);
                mouse.SetActive(false);
                fever.SetActive(false);
                ID.SetActive(false);

                flag_a = false;
                //재시작
                check = true;
                mask = true;
                act = true;
            }
            
        }
        else if(flag_r)//출입제한을 받았을 때, 왼쪽으로 가자.
        {
            ///버튼이 클릭되었을 때, 버튼 비활성화
            btnA.interactable = false;
            btnR.interactable = false;

            //증명서들 비활성화
            if (act)
            {
                itemCF.SetActive(false);
                itemID.SetActive(false);
                act = false;
            }

            rb.transform.position = Vector3.MoveTowards(transform.position, StartingPoint, speed); //5.5
            if (transform.position.x == StartingPoint.x)
            {
                wrong.SetActive(false);
                correct.SetActive(false);

                nomask.SetActive(false);
                nose.SetActive(false);
                mouse.SetActive(false);
                fever.SetActive(false);
                ID.SetActive(false);

                flag_r = false;
                //재시작
                check = true;
                mask = true;
                act = true;
            }
            
        }

    }


    void access()
    {
        flag_a = true;
    }
    void reject()
    {
        flag_r = true;
    }

    
}
