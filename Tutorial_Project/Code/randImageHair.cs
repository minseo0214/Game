using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randImageHair : MonoBehaviour
{
    public Image currentImage;
    public Sprite[] sprite;
    public static int hairindex;

    public void RandomImageFunction()
    {
        if(RandNameCheck.gender == 0) 
        {
            randImageHair.hairindex = Random.Range(0, 4);
            Sprite select = sprite[hairindex];
            currentImage.sprite = select;
        }
        else if (RandNameCheck.gender == 1)
        {
            randImageHair.hairindex = Random.Range(4, 8);
            Sprite select = sprite[hairindex];
            currentImage.sprite = select;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandNameCheck.buttonCheckHair == 1)
        {
            RandomImageFunction();
            RandNameCheck.buttonCheckHair = 0;
        }
    }
}
