using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnswerManagerScript : MonoBehaviour
{

    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject AnswerC;
    public GameObject titleBoard;

    private AnswerScript AnswerA_script;
    private AnswerScript AnswerB_script;
    private AnswerScript AnswerC_script;

    public float answerAScore = -1;
    public float answerBScore = 0;
    public float answerCScore = 1;

    public bool isAnswer = false;

    public float  playerScore = 0;

    public AudioSource answerSource;

    public AudioClip answerClip;


    private void Start()
    {
        AnswerA_script = AnswerA.GetComponent<AnswerScript>();
        AnswerB_script = AnswerB.GetComponent<AnswerScript>();
        AnswerC_script = AnswerC.GetComponent<AnswerScript>();
    }

    void Update()
    {
        if (AnswerA_script.touchPlayer == true && isAnswer == false)
        {
            isAnswer = true;
            playerScore = playerScore + answerAScore;
            Destroy(AnswerB);
            Destroy(AnswerC);
            Destroy(titleBoard);
            Debug.Log("Now Score: " + playerScore);
            answerSource.clip = answerClip;
            answerSource.Play();
        } 
        else if(AnswerB_script.touchPlayer == true && isAnswer == false)
        {
            isAnswer = true;
            playerScore = playerScore + answerBScore;
            Destroy(AnswerA);
            Destroy(AnswerC);
            Destroy(titleBoard);
            Debug.Log("Now Score: " + playerScore);
            answerSource.clip = answerClip;
            answerSource.Play();
        }
        else if(AnswerC_script.touchPlayer == true && isAnswer == false)
        {
            isAnswer = true;
            playerScore = playerScore + answerBScore;
            Destroy(AnswerA);
            Destroy(AnswerB);
            Destroy(titleBoard);
            Debug.Log("Now Score: " + playerScore);
            answerSource.clip = answerClip;
            answerSource.Play();
        }
    }
}
