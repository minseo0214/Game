using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutGameStart : MonoBehaviour
{
    public Image fade;
    public GameObject panel;
    float fades = 0.0f;

    void start()
    {
        panel.SetActive(false);
    }
    
    public void Fadebutton()
    {
        panel.SetActive(true);
        StartCoroutine(FadeCoroutine());
    }

    // Update is called once per frame
    IEnumerator FadeCoroutine()
    {
        while(fades < 1.0f)
        {
            fades += 0.01f;
            yield return new WaitForSeconds(0.01f);
            fade.color = new Color(0, 0, 0, fades);
        }
        fade.color = new Color(0, 0, 0, 0);
        panel.SetActive(false);
        GameObject.Find("ButtonEvent").GetComponent<BtnEvent>().MoveToGame();
    }
}
