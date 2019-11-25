using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class TextControl : MonoBehaviour
{
    public Text JokeText;
    public Text JokeAnswerText;
    public string []jokeLines;
    int jokeNumber= 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jokeLines[0] = "Knock Knock";
        jokeLines[1] = "I am.";
        jokeLines[2] = "You are Matt Parker, the person who is playing this game. If you are not Matt Parker close this fucking game right now or else I'll tear your tounge out of your eye holes.";
        JokeText.text = jokeLines[jokeNumber];
    }

    public void ChangeJoke()
    {
        if(JokeAnswerText.text == "Who's there?")
        {
            jokeNumber = 1;
        }

        if(JokeAnswerText.text == "I am who?")
        {
            jokeNumber = 2;
        }
    }

}
