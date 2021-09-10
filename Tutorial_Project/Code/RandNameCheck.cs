using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandNameCheck : MonoBehaviour
{
    public int a = 0;
    public static int CnameCheck = 0;
    public static int IDnameCheck = 0;
    public static int buttonCheckBody = 0;
    public static int buttonCheckHair = 0;
    public static int buttonCheckCloth = 0;
    public static int buttonCheckBlush = 0;
    public static int gender = 0;//0남자 1여자
    private string[] name = { "민준", "서준", "예준", "도윤", "시우", "주원", "하준", "지호", "지후", "준서", "준우", "현우", "도현", "지훈", "건우", "우진", "선우", "서진", "민재", "현준", "연우", "유준", "정우", "승우", "승현", "시윤", "준혁", "은우", "지환", "승민", "서연", "서윤", "지우", "서현", "민서", "하은", "하윤", "윤서", "지유", "지민", "채원", "지윤", "은서", "수아", "다은", "예은", "지아", "수빈", "소율", "예린", "예원", "지원", "소윤", "지안", "하린", "시은", "유진", "채은", "윤아", "유나" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       

    }
    public void GetIndex()
    {
        int index = 0;
        int IDindex = 0;
        RandNameCheck.buttonCheckBody = 1;
        RandNameCheck.buttonCheckHair = 1;
        RandNameCheck.buttonCheckCloth = 1;
        RandNameCheck.buttonCheckBlush = 1;
        gender = Random.Range(0, 2);
        if (RandNameCheck.gender == 0)
        {
            index = Random.Range(0, 30);
        }
        else if (RandNameCheck.gender == 1)
        {
            index = Random.Range(30, name.Length);
        }
        RandNameCheck.CnameCheck = index;
        a = Random.Range(0, 10);
        if (a < 5)
        {
            RandNameCheck.IDnameCheck = index;
        }
        else
        {
            while (true)
            {
                if (RandNameCheck.gender == 0)
                {
                    IDindex = Random.Range(0, 30);
                }
                else if (RandNameCheck.gender == 1)
                {
                    IDindex = Random.Range(30, name.Length);
                }
                if (index != IDindex)
                    break;
            }
        }
    }
}
