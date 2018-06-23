using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess;
    int tries = 5;

    public Text text;

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        text.text = guess.ToString();
        max += 1;
    }

	// Update is called once per frame
	void Update () {
        //old code for console
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So my guess was too small");
            min = guess;
            GuessAnswer(max, min);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So my guess was too high");
            max = guess;
            GuessAnswer(max, min);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I did it!");
            Debug.Log("Let's play again!");
            StartGame();
        }
        */


    }

    // If 'Too High' button was pressed
    public void guessLower()
    {
        min = guess;
        GuessAnswer(max, min);
    }

    // If 'Too Low' button was pressed
    public void guessHigher()
    {
        max = guess;
        GuessAnswer(max, min);
    }

    void GuessAnswer(int max, int min)
    {
        guess = Random.Range(min,max);
        text.text = guess.ToString();

        tries--;
        if (tries <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
