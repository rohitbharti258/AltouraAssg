using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class HomePage : MonoBehaviour
{   
    public void OnProject1Clicked()
    {
        SceneManager.LoadScene("P1");
    }

    public void OnProject2Clicked()
    {
        SceneManager.LoadScene("P2");
    }
    void Home(){
        SceneManager.LoadScene("Home");
    }
}
