using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderTimer : MonoBehaviour
{
    Slider slTimer;

    public Image fade;
    public GameObject panel;
    public bool startflag = false;
    bool flag = false;
    bool reduceflag = false;
    float fades = 0.0f;
    int level = 0;
    void Start()
    {
        slTimer = GetComponent<Slider>();
        panel.SetActive(false);
    }

    void Update()
    {
        if (startflag)
        {
            if (slTimer.value > 0.0f)
            {
                // 시간이 변경한 만큼 slider Value 변경을 합니다.
                if (reduceflag == true)
                {
                    slTimer.value -= 30;
                    reduceflag = false;
                }
                else
                {
                    slTimer.value -= Time.deltaTime;
                }
            }
            else if (flag == false)
            {
                panel.SetActive(true);
                StartCoroutine(FadeCoroutine());
                flag = true;
            }
        }
    }

    IEnumerator FadeCoroutine()
    {
        if (level < 2)
        {
            level += 1;
            while (fades < 1.0f)
            {
                fades += 0.01f;
                yield return new WaitForSeconds(0.01f);
                fade.color = new Color(0, 0, 0, fades);
            }
            slTimer.value = 180;
            fades = 0.0f;
            fade.color = new Color(0, 0, 0, 0);
            panel.SetActive(false);
            flag = false;
            GameObject.Find("ButtonEvent").GetComponent<BtnEvent>().MoveToStatic();
        }
        else
        {
            while (fades < 1.0f)
            {
                fades += 0.01f;
                yield return new WaitForSeconds(0.01f);
                fade.color = new Color(0, 0, 0, fades);
            }
            slTimer.value = 180;
            fades = 0.0f;
            fade.color = new Color(0, 0, 0, 0);
            panel.SetActive(false);
            flag = false;
            GameObject.Find("ButtonEvent").GetComponent<BtnEvent>().MoveToGameOver();
        }
    }

    public void ReduceTime()
    {
        reduceflag = true;
    }
}

