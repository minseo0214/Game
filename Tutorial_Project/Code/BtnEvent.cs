using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnEvent : MonoBehaviour
{
    public CanvasGroup mainGroup;
    public CanvasGroup gameGroup;
    public CanvasGroup howtoplayGroup;
    public CanvasGroup howtoplayGroup2;
    public CanvasGroup storyGroup;
    public CanvasGroup GameStatic;//통계화면
    public CanvasGroup GameOver;// 게임 종료 화면

    public BtnType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BtnType.New://Game Start 버튼입니다.
                CanvasGroupOn(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                CanvasGroupOff(GameStatic);
                //시간 시작
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = true;
                break;
            case BtnType.Story:
                CanvasGroupOff(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOn(storyGroup);
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.Back://뒤로가기 버튼입니다.
                CanvasGroupOff(gameGroup);
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //시간 멈춤
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.HowToPlay:
                CanvasGroupOff(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOn(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //시간 멈춤
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.HowToPlay2:
                CanvasGroupOff(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOn(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //시간 멈춤
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.Quit://종료버튼입니다.
                Application.Quit();
                break;
        }
    }
    public void MoveToStatic()
    {
        CanvasGroupOff(gameGroup);
        CanvasGroupOff(mainGroup);
        CanvasGroupOff(howtoplayGroup);
        CanvasGroupOff(howtoplayGroup2);
        CanvasGroupOff(storyGroup);
        CanvasGroupOn(GameStatic);
        //시간 멈춤
        GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
    }

    public void MoveToGame()
    {
        CanvasGroupOn(gameGroup);
        CanvasGroupOff(mainGroup);
        CanvasGroupOff(howtoplayGroup);
        CanvasGroupOff(howtoplayGroup2);
        CanvasGroupOff(storyGroup);
        CanvasGroupOff(GameStatic);
        //시간 시작
        GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = true;
    }

    public void MoveToGameOver()
    {
        CanvasGroupOff(gameGroup);
        CanvasGroupOff(mainGroup);
        CanvasGroupOff(howtoplayGroup);
        CanvasGroupOff(howtoplayGroup2);
        CanvasGroupOff(storyGroup);
        CanvasGroupOff(GameStatic);
        CanvasGroupOn(GameOver);
    }
    public void CanvasGroupOn(CanvasGroup cg)//씬을 게임화면에 보이게하고 상호작용하게 해줍니다.
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)//씬을 게임화면에 투명하게하고 상호작용하지않게 해줍니다.
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

