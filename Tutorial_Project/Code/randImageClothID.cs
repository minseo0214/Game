using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randImageClothID : MonoBehaviour
{
    public Image currentImage;
    public Sprite[] sprite;

    public void RandomImageFunction()
    {
        if (RandNameCheck.gender == 0)
        {
            int index = Random.Range(0, 4);
            Sprite select = sprite[index];
            currentImage.sprite = select;
        }
        else if (RandNameCheck.gender == 1)
        {
            int index = Random.Range(4, 8);
            Sprite select = sprite[index];
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
        if (IDrandName.IDcheck == 1)
        {
            Sprite select = sprite[randImageCloth.clothindex];
            currentImage.sprite = select;
            GameObject goImage = GameObject.Find("IDcloth");
            Color color = goImage.GetComponent<Image>().color;
            color.a = 1.0f;
            goImage.GetComponent<Image>().color = color;
        }
        else if (IDrandName.IDcheck == 0)
        {
            GameObject goImage = GameObject.Find("IDcloth");
            Color color = goImage.GetComponent<Image>().color;
            color.a = 0.0f;
            goImage.GetComponent<Image>().color = color;
        }
    }
}
