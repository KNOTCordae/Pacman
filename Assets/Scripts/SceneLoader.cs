using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}

