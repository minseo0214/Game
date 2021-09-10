using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randImageBody : MonoBehaviour
{
    public Image currentImage;
    public Sprite[] sprite;
    public static int bodyindex;

    public void RandomImageFunction()
    {
        if (RandNameCheck.gender == 0)
        {
            randImageBody.bodyindex = Random.Range(0, 4);
            Sprite select = sprite[bodyindex];
            currentImage.sprite = select;
        }
        else if (RandNameCheck.gender == 1)
        {
            randImageBody.bodyindex = Random.Range(4, 8);
            Sprite select = sprite[bodyindex];
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
        if(RandNameCheck.buttonCheckBody == 1)
        {
            RandomImageFunction();
            RandNameCheck.buttonCheckBody = 0;
        }
    }
}
