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
    public CanvasGroup GameStatic;//���ȭ��
    public CanvasGroup GameOver;// ���� ���� ȭ��

    public BtnType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BtnType.New://Game Start ��ư�Դϴ�.
                CanvasGroupOn(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                CanvasGroupOff(GameStatic);
                //�ð� ����
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
            case BtnType.Back://�ڷΰ��� ��ư�Դϴ�.
                CanvasGroupOff(gameGroup);
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //�ð� ����
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.HowToPlay:
                CanvasGroupOff(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOn(howtoplayGroup);
                CanvasGroupOff(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //�ð� ����
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.HowToPlay2:
                CanvasGroupOff(gameGroup);
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(howtoplayGroup);
                CanvasGroupOn(howtoplayGroup2);
                CanvasGroupOff(storyGroup);
                //�ð� ����
                GameObject.Find("Timer").GetComponent<SliderTimer>().startflag = false;
                break;
            case BtnType.Quit://�����ư�Դϴ�.
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
        //�ð� ����
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
        //�ð� ����
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
    public void CanvasGroupOn(CanvasGroup cg)//���� ����ȭ�鿡 ���̰��ϰ� ��ȣ�ۿ��ϰ� ���ݴϴ�.
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)//���� ����ȭ�鿡 �����ϰ��ϰ� ��ȣ�ۿ������ʰ� ���ݴϴ�.
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

