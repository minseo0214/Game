using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDFace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IDrandName.IDcheck == 1)
        {
            GameObject goImage = GameObject.Find("IDFace");
            Color color = goImage.GetComponent<Image>().color;
            color.a = 1.0f;
            goImage.GetComponent<Image>().color = color;
        }
        else if (IDrandName.IDcheck == 0)
        {
            GameObject goImage = GameObject.Find("IDFace");
            Color color = goImage.GetComponent<Image>().color;
            color.a = 0.0f;
            goImage.GetComponent<Image>().color = color;
        }
    }
}
