using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFadeOut : MonoBehaviour
{
    public Image image; //����

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 1; //ó�� ���İ�
        while (fadeCount > 0.0f)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.01f);//��ٷȴٰ� ����
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }
}
