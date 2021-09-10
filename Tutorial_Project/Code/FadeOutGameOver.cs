using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutGameOver : MonoBehaviour
{
    public UnityEngine.UI.Image fade;
    float fades = 0.0f;
    float time = 0;
    int score;
    //점수가 음수인지 확인하기

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("score").GetComponent<Score>().score;
        if (score < 0)
        {
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.1f)
            {
                fades += 0.1f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("GameOver");
                time = 0;
            }
        }
    }
}
