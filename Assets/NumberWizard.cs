using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to NUMBER WIZARD");
        Debug.Log("The WIZARD will guess your NUMBER");
        Debug.Log("The highest number the wizard can handle is " + max);
        Debug.Log("The lowest number the wizard can handle is " + min);
        Debug.Log("Is your number HIGHER or LOWER than " + guess + "?");
        Debug.Log("UP for HIGHER, DOWN for LOWER, ENTER for NAILED IT");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("HIGHER, you say");
            min = guess;
            NextGuess();
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("LOWER, you say");
            max = guess;
            NextGuess();
        }

        //Detect when the enter key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("You pressed the RETURN key, AKA the \"ENTER\" key");
            Debug.Log("GAME OVER");
            StartGame();
        }

        //Detect when the spacebar is pressed down
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You pressed the SPACEBAR!!! WHY!!!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number HIGHER or LOWER than " + guess + "?");
    }
}
