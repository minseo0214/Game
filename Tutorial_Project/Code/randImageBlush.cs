using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randImageBlush : MonoBehaviour
{
    public Image currentImage;
    public Sprite[] sprite;
    public int a;

    public void RandomImageFunction()
    {
        GameObject goImages = GameObject.Find("blush");
        Color color = goImages.GetComponent<Image>().color;
        color.a = 255.0f;
        goImages.GetComponent<Image>().color = color;
        a = Random.Range(0, 10);
        if (a < 1)
        {
            if (RandNameCheck.gender == 0)
            {
                int index = 0;
                Sprite select = sprite[index];
                currentImage.sprite = select;
            }
            else if (RandNameCheck.gender == 1)
            {
                int index = 1;
                Sprite select = sprite[index];
                currentImage.sprite = select;
            }
        }
        else
        {
            color.a = 0.0f;
            goImages.GetComponent<Image>().color = color;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandNameCheck.buttonCheckBlush == 1)
        {
            RandomImageFunction();
            RandNameCheck.buttonCheckBlush = 0;
        }
    }
}
