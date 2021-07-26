using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagement : MonoBehaviour
{
    static int score = 0;

    public static void SetScore(int value)
    {
        score += value;
    }

    public static int GetScore()
    {
        return score;
    }

    void OnGUI()
    {
        GUILayout.Label("Score : " + GetScore().ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
