using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int countAll = 0;
    public int countFail = 0;
    public int score = 0;

    public GameObject correct;
    public GameObject wrong;

    public GameObject nomask;//����ũ ������
    public GameObject nose;//�๰
    public GameObject mouse;//��
    public GameObject fever;//��
    public GameObject ID;//�ſ�


    bool corona = false;

    int check_mask;
    int check_nose;
    int check_mouse;
    
    int blush = 0;
    new int name= 0;
    Text textScore;
    // Start is called before the first frame update


    void Start()
    {
        textScore = GetComponent<Text>();
        correct.SetActive(false);
        wrong.SetActive(false);
        nomask.SetActive(false);
        nose.SetActive(false);
        mouse.SetActive(false);
        fever.SetActive(false);
        ID.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = 100 + 50 * (countAll - countFail);
        textScore.text = score.ToString() + "��";
    }

    public void clickAccess()
    {
        corona = GameObject.Find("item").GetComponent<RandomMask>().Corona;
        blush = GameObject.Find("blush").GetComponent<randImageBlush>().a;
        name = GameObject.Find("item").GetComponent<RandNameCheck>().a;

        if (blush < 1)//0�� �ƴ� ���� ĥ���������� �ڷγ���.
            corona = true;

        if (name > 4)//4���� ũ�� �̸��� �ٸ� ��
            corona = true;

        //Access�ߴµ� corona�� �߸� �ѱ� ��
        if (corona == true)
        {
            countFail += 1;
            GameObject.Find("Timer").GetComponent<SliderTimer>().ReduceTime();
            wrong.SetActive(true);

            //������ Ʋ�ȴ���
            check_mask = GameObject.Find("item").GetComponent<RandomMask>().randomMask;
            check_mouse = GameObject.Find("item").GetComponent<RandomMask>().randomMouse;
            check_nose = GameObject.Find("item").GetComponent<RandomMask>().randomNose;

            if (check_mask == 0)
                nomask.SetActive(true);
            if (check_mouse == 0)
                mouse.SetActive(true);
            if (check_nose == 0)
                nose.SetActive(true);
            if (blush < 1)
                fever.SetActive(true);
            if (name > 4)
                ID.SetActive(true);
            //�ٸ� ĳ���Ͱ� �����ϸ� ������� go start�� ����
        }
        //�������� ��
        else
        {
            correct.SetActive(true);
        }

        countAll += 1;
    }

    public void clickReject()
    {
        corona = GameObject.Find("item").GetComponent<RandomMask>().Corona;
        blush = GameObject.Find("blush").GetComponent<randImageBlush>().a;
        name = GameObject.Find("item").GetComponent<RandNameCheck>().a;

        if (blush < 1)//�߿��� ����, �ڷγ���.
            corona = true;

        if (name > 4)//5���� ũ�� �̸��� �ٸ� ��
            corona = true;

        //Reject�ߴµ� corona�� �ƴ�
        if (corona == false)
        {
            countFail += 1;
            GameObject.Find("Timer").GetComponent<SliderTimer>().ReduceTime();
            wrong.SetActive(true);

            //������ Ʋ�ȴ���
            check_mask = GameObject.Find("item").GetComponent<RandomMask>().randomMask;
            check_mouse = GameObject.Find("item").GetComponent<RandomMask>().randomMouse;
            check_nose = GameObject.Find("item").GetComponent<RandomMask>().randomNose;

            if (check_mask == 0)
                nomask.SetActive(true);
            if (check_mouse == 0)
                mouse.SetActive(true);
            if (check_nose == 0)
                nose.SetActive(true);
            if (blush < 1)
                fever.SetActive(true);
            if (name > 4)
                ID.SetActive(true);

        }
        //�����϶� O ǥ��
        else
        {
            correct.SetActive(true);
        }

        countAll += 1;
    }
}
