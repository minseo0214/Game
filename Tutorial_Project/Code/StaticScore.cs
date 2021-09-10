using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticScore : MonoBehaviour
{
    Text textscore;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        textscore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("score").GetComponent<Score>().score;
        textscore.text = score.ToString();
    }
}
