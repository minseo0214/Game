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

    public GameObject nomask;//마스크 미착용
    public GameObject nose;//콧물
    public GameObject mouse;//입
    public GameObject fever;//열
    public GameObject ID;//신원


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
        textScore.text = score.ToString() + "점";
    }

    public void clickAccess()
    {
        corona = GameObject.Find("item").GetComponent<RandomMask>().Corona;
        blush = GameObject.Find("blush").GetComponent<randImageBlush>().a;
        name = GameObject.Find("item").GetComponent<RandNameCheck>().a;

        if (blush < 1)//0이 아닌 색이 칠해져있으면 코로나임.
            corona = true;

        if (name > 4)//4보다 크면 이름이 다른 것
            corona = true;

        //Access했는데 corona라 잘못 넘긴 것
        if (corona == true)
        {
            countFail += 1;
            GameObject.Find("Timer").GetComponent<SliderTimer>().ReduceTime();
            wrong.SetActive(true);

            //무엇이 틀렸는지
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
            //다른 캐릭터가 등장하면 사라지게 go start에 있음
        }
        //성공했을 때
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

        if (blush < 1)//발열이 나면, 코로나임.
            corona = true;

        if (name > 4)//5보다 크면 이름이 다른 것
            corona = true;

        //Reject했는데 corona가 아님
        if (corona == false)
        {
            countFail += 1;
            GameObject.Find("Timer").GetComponent<SliderTimer>().ReduceTime();
            wrong.SetActive(true);

            //무엇이 틀렸는지
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
        //정답일때 O 표시
        else
        {
            correct.SetActive(true);
        }

        countAll += 1;
    }
}
