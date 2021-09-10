using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    //public UnityEngine.UI.Image fade;
    //float fades = 0.0f;
    public void SceneChange()
    {
        /*
        for(int i=0; i < 10; i++)
        {
            fades += 0.1f;
            fade.color = new Color(0, 0, 0, fades);
        }*/
        SceneManager.LoadScene("SampleScene");
    }
}
