using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMask : MonoBehaviour
{

    //�����̹�����  ����ϴ� ������Ʈ
    public Image Mask;
    //�๰�� �ִ� �̹���
    public Image Nose;
    //���� �ִ� �̹���
    public Image Mouse;
    //�� �̹���
    public Image Face;

    // Start is called before the first frame update

    //����ũ �̹�����
    public Sprite mask1;
    public Sprite mask2;
    public Sprite mask3;
    public Sprite mask4;
    public Sprite mask5;
    public Sprite mouse;
    public Sprite nose;

    //���� ����
    public int randomMask = 0;
    public int selectMask = 0;
    public int randomNose = 0;
    public int randomMouse = 0;
    public int randomFace = 0;

    //�Ÿ�������� �ƴ��� �Ǵ�.
    public bool Corona = false;

    //�̸񱸺񷣴�
    public Sprite face1;
    public Sprite face2;
    public Sprite face3;
    public Sprite face4;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Appear()//ĳ���Ͱ� ������ �� ȣ���ϱ�.
    {
        //����ũ�� �������� 0�̸� �Ⱦ� ��
        randomMask = Random.Range(0, 10);
        //� ����ũ�� �����Ұ���
        selectMask = Random.Range(0, 5);
        //�๰�� �ִ°� ���°� 0�̸� �ִ� ��
        randomNose = Random.Range(0, 10);
        //���� �Է��ִ°� �ƴѰ� 0�̸� �շ��ִ� ��
        randomMouse = Random.Range(0, 10);
        //�� ����
        randomFace = Random.Range(0, 4);

        //����ũ
        if (randomMask == 0)//����ũ ���°�
        {
            Mask.enabled = false; //����ũ �Ⱥ��̰�
            Mouse.enabled = false; //���� �Ⱥ��̰�
        }
        else if (randomMask != 0)//����ũ �� ��
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

            //����ũ�� ���� ��, ���� ���̴°�.
            if (randomMouse == 0)//���� �շ��ִ� ��
            {
                Mouse.sprite = mouse;
                Mouse.enabled = true;
            }
            else
            {
                Mouse.enabled = false;
            }
        }

        //�๰
        if (randomNose == 0)//�๰�� �ִ� ��
        {
            Nose.sprite = nose;
            Nose.enabled = true;
        }
        else
        {
            Nose.enabled = false;
        }

        //��
        if (randomFace == 0)
            Face.sprite = face1;
        else if (randomFace == 1)
            Face.sprite = face2;
        else if (randomFace == 2)
            Face.sprite = face3;
        else if (randomFace == 3)
            Face.sprite = face4;

        //�ڷγ��ΰ�.
        if (randomMask == 0 || randomMouse == 0 || randomNose == 0)
        {
            Corona = true;//�ڷγ���.
        }
        else
        {
            Corona = false;//�ڷγ� �ƴ�.
        }
    }
}
