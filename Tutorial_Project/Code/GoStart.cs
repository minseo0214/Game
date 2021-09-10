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

    public GameObject nomask;//����ũ ������
    public GameObject nose;//�๰
    public GameObject mouse;//��
    public GameObject fever;//��
    public GameObject ID;//�ſ�

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
        StartingPoint = transform.position;//ó���� ��ġ�� ����
        target = GameObject.Find("Window").transform.position;
        endtarget = GameObject.Find("Window").transform.position;
        target.y = StartingPoint.y;
        endtarget.y = StartingPoint.y;
        endtarget.x = 2 * target.x;

        Access.onClick.AddListener(access);
        Reject.onClick.AddListener(reject);

        //��ư�� ��Ȱ��ȭ ��Ű�� ����
        btnA = GameObject.Find("btnAccess").GetComponent<Button>();
        btnR = GameObject.Find("btnReject").GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x);
        //ó�� ������ ��
        if (check)
        {
            if (mask)//����ũ�� �� ���� ���� ����.
            {
                GameObject.Find("item").GetComponent<RandomMask>().Appear();
                GameObject.Find("item").GetComponent<RandNameCheck>().GetIndex();
                mask = false;
            }

            rb.transform.position = Vector3.MoveTowards(transform.position, target, speed);
            if (transform.position.x == target.x)
            {
                check = false;
                //�߾ӿ� ���� �� ��ư Ȱ��ȭ
                btnA.interactable = true;
                btnR.interactable = true;

                //�ٽ� Ȱ��ȭ
                itemCF.SetActive(true);
                itemID.SetActive(true);
            }
            
            
        }
        else if(flag_a)//�����㰡�� �޾��� ��, ���������� ����.
        {
            //��ư�� Ŭ���Ǿ��� ��, ��ư ��Ȱ��ȭ
            btnA.interactable = false;
            btnR.interactable = false;


            //������ ��Ȱ��ȭ
            if (act)
            {
                itemCF.SetActive(false);
                itemID.SetActive(false);
                act = false;
            }

            rb.transform.position = Vector3.MoveTowards(transform.position, endtarget, speed);
            if (transform.position.x == endtarget.x)
            {
                transform.position = StartingPoint;//���� ��ġ��
                wrong.SetActive(false);
                correct.SetActive(false);

                nomask.SetActive(false);
                nose.SetActive(false);
                mouse.SetActive(false);
                fever.SetActive(false);
                ID.SetActive(false);

                flag_a = false;
                //�����
                check = true;
                mask = true;
                act = true;
            }
            
        }
        else if(flag_r)//���������� �޾��� ��, �������� ����.
        {
            ///��ư�� Ŭ���Ǿ��� ��, ��ư ��Ȱ��ȭ
            btnA.interactable = false;
            btnR.interactable = false;

            //������ ��Ȱ��ȭ
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
                //�����
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
