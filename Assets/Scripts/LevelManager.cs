﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void quitLevel()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
