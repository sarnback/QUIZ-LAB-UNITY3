using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackStandard; // Standard waiting
    public GameObject answerAbackGreen; // Green Correct
    public GameObject answerAbackRed; // Red Wrong
    public GameObject answerBbackStandard; 
    public GameObject answerBbackGreen; 
    public GameObject answerBbackRed; 
    public GameObject answerCbackStandard; 
    public GameObject answerCbackGreen; 
    public GameObject answerCbackRed; 
    public GameObject answerDbackStandard; 
    public GameObject answerDbackGreen; 
    public GameObject answerDbackRed;
    
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    //ljud effekter
    public AudioSource correctFX;
    public AudioSource wrongFX;

    //score
    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;

    public GameObject bestDisplay;

    //PlayerPrefs.GetInt hämtar en Int från "BestScoreQuiz"
  void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    private void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
    }

    //KNAPP FÖR SVAR A
    public void AnswerA()
    {
        //Är knapp A rätt svar + 5 poäng
        if (QuestionGenerate.actualAnswer == "A")
        {
            //Ändrar från standard button färg till grön spela correctFX ljud
            answerAbackGreen.SetActive(true);
            answerAbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa röd och spela wrongFX - 5 poäng
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackStandard.SetActive(false);
            wrongFX.Play();
            scoreValue -= 5;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        //Startar coroutine ny fråga
        StartCoroutine(NextQuestion());
    }
    //KNAPP FÖR SVAR B
    public void AnswerB()
    {
        //Är knapp B rätt svar + 5 poäng
        if (QuestionGenerate.actualAnswer == "B")
        {
            //Ändrar från standard button färg till grön  spela correctFX ljud
            answerBbackGreen.SetActive(true);
            answerBbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa röd och spela wrongFX - 5 poäng
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackStandard.SetActive(false);
            wrongFX.Play();
            scoreValue -= 5;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        //Startar coroutine ny fråga
        StartCoroutine(NextQuestion());
    }
    public void AnswerC()
    {
        //Är knapp C rätt svar + 5 poäng
        if (QuestionGenerate.actualAnswer == "C")
        {
            //Ändrar från standard button färg till grön  spela correctFX ljud
            answerCbackGreen.SetActive(true);
            answerCbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa röd och spela wrongFX - 5 poäng
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackStandard.SetActive(false);
            wrongFX.Play();
            scoreValue -= 5;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        //Startar coroutine ny fråga
        StartCoroutine(NextQuestion());
    }
    public void AnswerD()
    {
        //Är knapp D rätt svar + 5 poäng
        if (QuestionGenerate.actualAnswer == "D")
        {
            //Ändrar från standard button färg till grön  spela correctFX ljud
            answerDbackGreen.SetActive(true);
            answerDbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa röd och spela wrongFX - 5 poäng
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackStandard.SetActive(false);
            wrongFX.Play();
            scoreValue -= 5;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        //Startar coroutine ny fråga
        StartCoroutine(NextQuestion());
    }
    //Enumerator som väntar 2 sekunder efter man har gissat innan next question genereas
    IEnumerator NextQuestion()
    {
        //PlayerPrefs setter scoreValue till "BestScoreQuiz"
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            //updatar bestscore 
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        }
        yield return new WaitForSeconds(2);
        //ändrar färg tillbaka till standard
        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackStandard.SetActive(true);
        answerBbackStandard.SetActive(true);
        answerCbackStandard.SetActive(true);
        answerDbackStandard.SetActive(true);

        //Enablar buttons igen

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        //Generera ny fråga
        QuestionGenerate.displayingQuestion = false;



    }
}
