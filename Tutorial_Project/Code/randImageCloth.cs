using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randImageCloth : MonoBehaviour
{
    public Image currentImage;
    public Sprite[] sprite;
    public static int clothindex;

    public void RandomImageFunction()
    {
        if (RandNameCheck.gender == 0)
        {
            randImageCloth.clothindex = Random.Range(0, 4);
            Sprite select = sprite[randImageCloth.clothindex];
            currentImage.sprite = select;
        }
        else if (RandNameCheck.gender == 1)
        {
            randImageCloth.clothindex = Random.Range(4, 8);
            Sprite select = sprite[randImageCloth.clothindex];
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
        if(RandNameCheck.buttonCheckCloth == 1)
        {
            RandomImageFunction();
            RandNameCheck.buttonCheckCloth = 0;
        }
    }
}
