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

    //PlayerPrefs.GetInt h�mtar en Int fr�n "BestScoreQuiz"
  void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    private void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
    }

    //KNAPP F�R SVAR A
    public void AnswerA()
    {
        //�r knapp A r�tt svar + 5 po�ng
        if (QuestionGenerate.actualAnswer == "A")
        {
            //�ndrar fr�n standard button f�rg till gr�n spela correctFX ljud
            answerAbackGreen.SetActive(true);
            answerAbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa r�d och spela wrongFX - 5 po�ng
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
        //Startar coroutine ny fr�ga
        StartCoroutine(NextQuestion());
    }
    //KNAPP F�R SVAR B
    public void AnswerB()
    {
        //�r knapp B r�tt svar + 5 po�ng
        if (QuestionGenerate.actualAnswer == "B")
        {
            //�ndrar fr�n standard button f�rg till gr�n  spela correctFX ljud
            answerBbackGreen.SetActive(true);
            answerBbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa r�d och spela wrongFX - 5 po�ng
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
        //Startar coroutine ny fr�ga
        StartCoroutine(NextQuestion());
    }
    public void AnswerC()
    {
        //�r knapp C r�tt svar + 5 po�ng
        if (QuestionGenerate.actualAnswer == "C")
        {
            //�ndrar fr�n standard button f�rg till gr�n  spela correctFX ljud
            answerCbackGreen.SetActive(true);
            answerCbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa r�d och spela wrongFX - 5 po�ng
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
        //Startar coroutine ny fr�ga
        StartCoroutine(NextQuestion());
    }
    public void AnswerD()
    {
        //�r knapp D r�tt svar + 5 po�ng
        if (QuestionGenerate.actualAnswer == "D")
        {
            //�ndrar fr�n standard button f�rg till gr�n  spela correctFX ljud
            answerDbackGreen.SetActive(true);
            answerDbackStandard.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        //annars visa r�d och spela wrongFX - 5 po�ng
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
        //Startar coroutine ny fr�ga
        StartCoroutine(NextQuestion());
    }
    //Enumerator som v�ntar 2 sekunder efter man har gissat innan next question genereas
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
        //�ndrar f�rg tillbaka till standard
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

        //Generera ny fr�ga
        QuestionGenerate.displayingQuestion = false;



    }
}
