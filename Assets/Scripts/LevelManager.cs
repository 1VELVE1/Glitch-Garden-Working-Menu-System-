﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {
            Debug.Log("Level auto load disabled, use a postive number is seconds");
        }
        else
        {
            Invoke("LoadNextScene", autoLoadNextLevelAfter);
        }

    }

    public void LoadLevel(string name)
    {
    
        SceneManager.LoadScene(name);

    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void LoadNextScene()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
  

