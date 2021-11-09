using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    
    public static string actualAnswer;
    //kollar om vi generar en fråga eller ej
    public static bool displayingQuestion = false;

    //int som skall användas för slumpa
    public int questionNumber;

    //Skickar in från Question display
    //matar endast in inforamtion till Unity
 
    // Update is called once per frame
    void Update()
    {


        //om vi inte visar en fråga så vill vi visa en fråga
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 27);
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "How much wood could a wood chuck chuck if a wood chuck could chuck wood?";
                QuestionDisplay.newA = "A. Lots and lots of wood";
                QuestionDisplay.newB = "B. Not that much";
                QuestionDisplay.newC = "C. Hardly any";
                QuestionDisplay.newD = "D. Five";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who is the brother of Luigi?";
                QuestionDisplay.newA = "A. Toad";
                QuestionDisplay.newB = "B. Bowser";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Goomba";
                actualAnswer = "C";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "What color is the sky?";
                QuestionDisplay.newA = "A. Green";
                QuestionDisplay.newB = "B. Blue";
                QuestionDisplay.newC = "C. Black";
                QuestionDisplay.newD = "D. Yellow";
                actualAnswer = "B";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "What´s my creators name?";
                QuestionDisplay.newA = "A. Umbrella co";
                QuestionDisplay.newB = "B. Donkey Kong";
                QuestionDisplay.newC = "C. Uncle Bob";
                QuestionDisplay.newD = "D. Alexander";
                actualAnswer = "D";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "From wich game comes the T-Virus?";
                QuestionDisplay.newA = "A. Pharmaphobia";
                QuestionDisplay.newB = "B. Phasmophobia";
                QuestionDisplay.newC = "C. Resident Evil";
                QuestionDisplay.newD = "D. Bloodbourne";
                actualAnswer = "C";
            }
            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Many people in Mexico celebrate Halloween by eating what ghoulish candy treat?";
                QuestionDisplay.newA = "A. Sweet skulls";
                QuestionDisplay.newB = "B. Red hot sweet peppers";
                QuestionDisplay.newC = "C. Hot skulls";
                QuestionDisplay.newD = "D. Candy corn";
                actualAnswer = "A";
            }
            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Halloween was first celebrated by which ancient priests?";
                QuestionDisplay.newA = "A. Shamans";
                QuestionDisplay.newB = "B. Wich Doctors";
                QuestionDisplay.newC = "C. Cermonial priests";
                QuestionDisplay.newD = "D. Druids";
                actualAnswer = "D";
            }
            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "What’s the color order of a piece of candy corn, from the base to the point?";
                QuestionDisplay.newA = "A. White (base), orange (middle), and yellow (top)";
                QuestionDisplay.newB = "B. Yellow (base), white (middle), and orange (top)";
                QuestionDisplay.newC = "C. Yellow (base), orange (middle), and white (top)";
                QuestionDisplay.newD = "D. Orange (base), yellow (middle), and white (top)";
                actualAnswer = "C";
            }
            if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Out of which vegetable were Jack O’ Lanterns originally made?";
                QuestionDisplay.newA = "A. Turnips";
                QuestionDisplay.newB = "B. Cucumber";
                QuestionDisplay.newC = "C. Apple";
                QuestionDisplay.newD = "D. Orange";
                actualAnswer = "A";
            }
            if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "What was Dracula’s real name?";
                QuestionDisplay.newA = "A. Vladimir";
                QuestionDisplay.newB = "B. Vlad";
                QuestionDisplay.newC = "C. Vlad the Impaler";
                QuestionDisplay.newD = "D. Van Helsing";
                actualAnswer = "C";
            }
            if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "From which words did ‘bonfire’ originate?";
                QuestionDisplay.newA = "A. Bone and guts";
                QuestionDisplay.newB = "B. Bone and fire";
                QuestionDisplay.newC = "C. Bone and dire";
                QuestionDisplay.newD = "D. Bone and blood";
                actualAnswer = "C";
            }
            if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Which Catholic Church holiday is Halloween linked to?";
                QuestionDisplay.newA = "A. Saint Peters Catholic church";
                QuestionDisplay.newB = "B. All Saints (Hallows) Day";
                QuestionDisplay.newC = "C. Holy Mary church";
                QuestionDisplay.newD = "D. Knutby";
                actualAnswer = "A";
            }
            if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "In which country did Halloween originate?";
                QuestionDisplay.newA = "A. Ireland";
                QuestionDisplay.newB = "B. Mexiko";
                QuestionDisplay.newC = "C. Spain";
                QuestionDisplay.newD = "D. France";
                actualAnswer = "A";
            }
            if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "What classic horror film features the quote, “They’re coming to get you, Barbara”?";
                QuestionDisplay.newA = "A. Night of the Living Dead";
                QuestionDisplay.newB = "B. Gremlins";
                QuestionDisplay.newC = "C. Chucky";
                QuestionDisplay.newD = "D. Day of the dead";
                actualAnswer = "A";
            }

            if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "In the Texas Chainsaw Massacre, what is the name of Leatherface’s family?";
                QuestionDisplay.newA = "A. The Simpsons";
                QuestionDisplay.newB = "B. The Thompsons";
                QuestionDisplay.newC = "C. The Sawyers";
                QuestionDisplay.newD = "D. The McDonalds";
                actualAnswer = "C";
            }

            if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "What is the original name for what we now call Candy Corn?";
                QuestionDisplay.newA = "A. Sweet Corn";
                QuestionDisplay.newB = "B. Chicken feed";
                QuestionDisplay.newC = "C. Black Corn";
                QuestionDisplay.newD = "D. Yellow Corn";
                actualAnswer = "B";
            }
            if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "What´s my creators name?";
                QuestionDisplay.newA = "A. Umbrella co";
                QuestionDisplay.newB = "B. Donkey Kong";
                QuestionDisplay.newC = "C. Uncle Bob";
                QuestionDisplay.newD = "D. Alexander";
                actualAnswer = "D";
            }
            if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "From wich game comes the T-Virus?";
                QuestionDisplay.newA = "A. Pharmaphobia";
                QuestionDisplay.newB = "B. Phasmophobia";
                QuestionDisplay.newC = "C. Resident Evil";
                QuestionDisplay.newD = "D. Bloodbourne";
                actualAnswer = "C";
            }
            if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Many people in Mexico celebrate Halloween by eating what ghoulish candy treat?";
                QuestionDisplay.newA = "A. Sweet skulls";
                QuestionDisplay.newB = "B. Red hot sweet peppers";
                QuestionDisplay.newC = "C. Hot skulls";
                QuestionDisplay.newD = "D. Candy corn";
                actualAnswer = "A";
            }
            if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Halloween was first celebrated by which ancient priests?";
                QuestionDisplay.newA = "A. Shamans";
                QuestionDisplay.newB = "B. Wich Doctors";
                QuestionDisplay.newC = "C. Cermonial priests";
                QuestionDisplay.newD = "D. Druids";
                actualAnswer = "D";
            }
            if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "What’s the color order of a piece of candy corn, from the base to the point?";
                QuestionDisplay.newA = "A. White (base), orange (middle), and yellow (top)";
                QuestionDisplay.newB = "B. Yellow (base), white (middle), and orange (top)";
                QuestionDisplay.newC = "C. Yellow (base), orange (middle), and white (top)";
                QuestionDisplay.newD = "D. Orange (base), yellow (middle), and white (top)";
                actualAnswer = "C";
            }
            if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Out of which vegetable were Jack O’ Lanterns originally made?";
                QuestionDisplay.newA = "A. Turnips";
                QuestionDisplay.newB = "B. Cucumber";
                QuestionDisplay.newC = "C. Apple";
                QuestionDisplay.newD = "D. Orange";
                actualAnswer = "A";
            }
            if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "What was Dracula’s real name?";
                QuestionDisplay.newA = "A. Vladimir";
                QuestionDisplay.newB = "B. Vlad";
                QuestionDisplay.newC = "C. Vlad the Impaler";
                QuestionDisplay.newD = "D. Van Helsing";
                actualAnswer = "C";
            }
            if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "From which words did ‘bonfire’ originate?";
                QuestionDisplay.newA = "A. Bone and guts";
                QuestionDisplay.newB = "B. Bone and fire";
                QuestionDisplay.newC = "C. Bone and dire";
                QuestionDisplay.newD = "D. Bone and blood";
                actualAnswer = "C";
            }
            if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Which Catholic Church holiday is Halloween linked to?";
                QuestionDisplay.newA = "A. Saint Peters Catholic church";
                QuestionDisplay.newB = "B. All Saints (Hallows) Day";
                QuestionDisplay.newC = "C. Holy Mary church";
                QuestionDisplay.newD = "D. Knutby";
                actualAnswer = "A";
            }
            if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "In which country did Halloween originate?";
                QuestionDisplay.newA = "A. Ireland";
                QuestionDisplay.newB = "B. Mexiko";
                QuestionDisplay.newC = "C. Spain";
                QuestionDisplay.newD = "D. France";
                actualAnswer = "A";
            }


            // alla frågor är ovan denna kod, sätter updateQuestion till false så ny fråga genereras
            QuestionDisplay.updateQuestion = false;
        }
    }
}
