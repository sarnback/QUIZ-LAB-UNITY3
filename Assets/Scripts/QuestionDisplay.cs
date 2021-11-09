using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    //bool för kunna update question
    public static bool updateQuestion = false;

 
    // Update is called once per frame
    void Update()
    {
        if (updateQuestion == false)
        {
            updateQuestion = true;
            StartCoroutine(PushTextOnScreen());
        }  
    }
    //Coroutine
    IEnumerator PushTextOnScreen()
    {
        //väntar 0,25 sek innan de visar text för för förhindra timing problem i display
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Text>().text = newQuestion;
        answerA.GetComponent<Text>().text = newA;
        answerB.GetComponent<Text>().text = newB;
        answerC.GetComponent<Text>().text = newC;
        answerD.GetComponent<Text>().text = newD;
    }
}
