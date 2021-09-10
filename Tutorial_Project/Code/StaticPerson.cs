using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticPerson : MonoBehaviour
{
    Text texttotal;
    int total;
    // Start is called before the first frame update
    void Start()
    {
        texttotal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        total = GameObject.Find("score").GetComponent<Score>().countAll;
        texttotal.text = total.ToString();
    }
}
