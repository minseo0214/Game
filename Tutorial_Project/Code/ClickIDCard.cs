using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickIDCard : MonoBehaviour
{
    bool check = false;
    
    public int L_Xposition = 0;
    public int L_Yposition = 0;

    public int S_Xposition = 0;
    public int S_Yposition = 0;

    public void clickCard()
    {
        
        GameObject obj = GameObject.Find("itemID");
        RectTransform rectTran = obj.GetComponent<RectTransform>();
        Vector3 position = obj.transform.localPosition;
        if (check == false)
        {
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 710);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 403);
            position.x = L_Xposition;
            position.y = L_Yposition;
            obj.transform.localPosition = position;
            check = true;
        }
        else
        {
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 395);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 230);
            position.x = S_Xposition;
            position.y = S_Yposition;
            obj.transform.localPosition = position;
            check = false;
        }
    }
}
