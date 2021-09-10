using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMask : MonoBehaviour
{

    //랜덤이미지를  출력하는 오브젝트
    public Image Mask;
    //콧물이 있는 이미지
    public Image Nose;
    //입이 있는 이미지
    public Image Mouse;
    //얼굴 이미지
    public Image Face;

    // Start is called before the first frame update

    //마스크 이미지들
    public Sprite mask1;
    public Sprite mask2;
    public Sprite mask3;
    public Sprite mask4;
    public Sprite mask5;
    public Sprite mouse;
    public Sprite nose;

    //랜덤 변수
    public int randomMask = 0;
    public int selectMask = 0;
    public int randomNose = 0;
    public int randomMouse = 0;
    public int randomFace = 0;

    //거를사람인지 아닌지 판단.
    public bool Corona = false;

    //이목구비랜덤
    public Sprite face1;
    public Sprite face2;
    public Sprite face3;
    public Sprite face4;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Appear()//캐릭터가 등장할 대 호출하기.
    {
        //마스크를 착용유무 0이면 안쓴 것
        randomMask = Random.Range(0, 10);
        //어떤 마스크를 착용할건지
        selectMask = Random.Range(0, 5);
        //콧물이 있는가 없는가 0이면 있는 것
        randomNose = Random.Range(0, 10);
        //입이 뚤려있는가 아닌가 0이면 뚫려있는 것
        randomMouse = Random.Range(0, 10);
        //얼굴 랜덤
        randomFace = Random.Range(0, 4);

        //마스크
        if (randomMask == 0)//마스크 없는것
        {
            Mask.enabled = false; //마스크 안보이게
            Mouse.enabled = false; //입이 안보이게
        }
        else if (randomMask != 0)//마스크 쓴 것
        {
            if (selectMask == 0)
                Mask.sprite = mask1;
            else if(selectMask == 1)
                Mask.sprite = mask2;
            else if(selectMask == 2)
                Mask.sprite = mask3;
            else if (selectMask == 3)
                Mask.sprite = mask4;
            else if (selectMask == 4)
                Mask.sprite = mask5;
            Mask.enabled = true;

            //마스크를 썼을 때, 입이 보이는가.
            if (randomMouse == 0)//입이 뚫려있는 것
            {
                Mouse.sprite = mouse;
                Mouse.enabled = true;
            }
            else
            {
                Mouse.enabled = false;
            }
        }

        //콧물
        if (randomNose == 0)//콧물이 있는 것
        {
            Nose.sprite = nose;
            Nose.enabled = true;
        }
        else
        {
            Nose.enabled = false;
        }

        //얼굴
        if (randomFace == 0)
            Face.sprite = face1;
        else if (randomFace == 1)
            Face.sprite = face2;
        else if (randomFace == 2)
            Face.sprite = face3;
        else if (randomFace == 3)
            Face.sprite = face4;

        //코로나인가.
        if (randomMask == 0 || randomMouse == 0 || randomNose == 0)
        {
            Corona = true;//코로나임.
        }
        else
        {
            Corona = false;//코로나 아님.
        }
    }
}
