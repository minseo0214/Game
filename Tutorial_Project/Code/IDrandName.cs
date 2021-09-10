using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDrandName : MonoBehaviour
{
    public Text currentText;
    public static int IDcheck = 0;
    private string[] name = {"민준","서준","예준","도윤","시우","주원","하준","지호","지후","준서","준우","현우","도현","지훈","건우","우진","선우","서진","민재","현준","연우","유준","정우","승우","승현","시윤","준혁","은우","지환","승민","서연","서윤","지우","서현","민서","하은","하윤","윤서","지유","지민","채원","지윤","은서","수아","다은","예은","지아","수빈","소율","예린","예원","지원","소윤","지안","하린","시은","유진","채은","윤아","유나"};

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
