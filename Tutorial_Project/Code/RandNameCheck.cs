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
    public static int gender = 0;//0���� 1����
    private string[] name = { "����", "����", "����", "����", "�ÿ�", "�ֿ�", "����", "��ȣ", "����", "�ؼ�", "�ؿ�", "����", "����", "����", "�ǿ�", "����", "����", "����", "����", "����", "����", "����", "����", "�¿�", "����", "����", "����", "����", "��ȯ", "�¹�", "����", "����", "����", "����", "�μ�", "����", "����", "����", "����", "����", "ä��", "����", "����", "����", "����", "����", "����", "����", "����", "����", "����", "����", "����", "����", "�ϸ�", "����", "����", "ä��", "����", "����" };
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
