using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    public bool loadNextQuestion;


    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer() {
        timerValue = 0;
    }

    private void UpdateTimer() {
        timerValue = timerValue - Time.deltaTime;
        if(isAnsweringQuestion == true) {

            if(timerValue > 0) {
                fillFraction = timerValue / timeToCompleteQuestion;

            } else {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        } else {
            if(timerValue > 0) {
                fillFraction = timerValue / timeToShowCorrectAnswer;

            } else {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
   
}
