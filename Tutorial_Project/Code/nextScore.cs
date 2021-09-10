using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextScore : MonoBehaviour
{
    public int total;
    public int fail;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        total = GameObject.Find("Score").GetComponent<Score>().countAll;
        fail = GameObject.Find("Score").GetComponent<Score>().countFail;
        score = GameObject.Find("Score").GetComponent<Score>().score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
