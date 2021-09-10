using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticFail : MonoBehaviour
{
    Text textfail;
    int fail;
    // Start is called before the first frame update
    void Start()
    {
        textfail = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fail = GameObject.Find("score").GetComponent<Score>().countFail;
        textfail.text = fail.ToString();
    }
}