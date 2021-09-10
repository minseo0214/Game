using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDrandName : MonoBehaviour
{
    public Text currentText;
    public static int IDcheck = 0;
    private string[] name = {"����","����","����","����","�ÿ�","�ֿ�","����","��ȣ","����","�ؼ�","�ؿ�","����","����","����","�ǿ�","����","����","����","����","����","����","����","����","�¿�","����","����","����","����","��ȯ","�¹�","����","����","����","����","�μ�","����","����","����","����","����","ä��","����","����","����","����","����","����","����","����","����","����","����","����","����","�ϸ�","����","����","ä��","����","����"};

    void RandomNameFunction()
    {
        int index = Random.Range(0, name.Length);
        string select = name[index];
        currentText.text = select;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayName();   
    }
    public void DisplayName()
    {
        if(IDrandName.IDcheck == 1)
        {
            string select = name[RandNameCheck.IDnameCheck];
            currentText.text = select;
        }
        else if(IDrandName.IDcheck == 0)
        {
            currentText.text = "";
        }
        
    }
}
