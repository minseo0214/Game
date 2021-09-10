using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFadeOut : MonoBehaviour
{
    public Image image; //투명

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 1; //처음 알파값
        while (fadeCount > 0.0f)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.01f);//기다렸다가 실행
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }
}
