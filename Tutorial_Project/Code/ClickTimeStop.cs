using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTimeStop : MonoBehaviour
{
    bool check=false;
    // Start is called before the first frame update
    public void TimeStop()
    {
        if (check == false)//�ð� ��� �귯��
        {
            Time.timeScale = 1;
            check = true;
        }
        else//�ð� ����
        {
            Time.timeScale = 0;
            check = false;
        }
    }
}
