using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class TextControl : MonoBehaviour
{
    //i have an error about needing to submit twice no idea why it's happening
    public Text JokeText;
    public Text JokeAnswerText;
    public string []jokeLines;
    int jokeNumber= 0;

    
 

    public void ChangeJoke()
    {
        //only change joke if the string is correct, calls this on click of submit
     
        JokeText.text = jokeLines[jokeNumber];
        if (JokeAnswerText.text == "Who's there?")
        {
            jokeNumber = 1;
        }

        if(JokeAnswerText.text == "I am who?")
        {
            jokeNumber = 2;
        }
      
    }

}
