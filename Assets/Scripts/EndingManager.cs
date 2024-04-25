using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    public GameObject amA;
    public GameObject amB;
    public GameObject amC;
    public GameObject amD;
    public GameObject amE;

    private AnswerManagerScript amAScript;
    private AnswerManagerScript amBScript;
    private AnswerManagerScript amCScript;
    private AnswerManagerScript amDScript;
    private AnswerManagerScript amEScript;

    private float finalScore = 0;

    //trigger object
    public GameObject triggerObject1;
    public GameObject triggerObject2;
    public GameObject triggerObject3;
    public GameObject triggerObject4;

    private float answerNum = 0;

    bool[] answerList = new bool[5];
    bool[] checkList = new bool[5];

    // Start is called before the first frame update
    void Start()
    {
        amAScript = amA.GetComponent<AnswerManagerScript>();
        amBScript = amB.GetComponent<AnswerManagerScript>();
        amCScript = amC.GetComponent<AnswerManagerScript>();
        amDScript = amD.GetComponent<AnswerManagerScript>();
        amEScript = amE.GetComponent<AnswerManagerScript>();

        triggerObject1.SetActive(false);
        triggerObject2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        answerList[0] = amAScript.isAnswer;
        answerList[1] = amBScript.isAnswer;
        answerList[2] = amCScript.isAnswer;
        answerList[3] = amDScript.isAnswer;
        answerList[4] = amEScript.isAnswer;

        for (int i = 0; i < answerList.Length; i++)
        {
            if (answerList[i] == true && answerList[i] != checkList[i])
            {
                answerNum = answerNum + 1;
                checkList[i] = answerList[i];
                Debug.Log("answerNum now is " + answerNum);
                if(answerNum == 1)
                {
                    triggerObject1.SetActive(true);
                }else if (answerNum == 2)
                {
                    triggerObject2.SetActive(true);
                }else if(answerNum == 3)
                {
                    triggerObject3.SetActive(true);
                }else if (answerNum == 4)
                {
                    triggerObject4.SetActive(true);
                }
            }
        }

        if (amAScript.isAnswer == true && amBScript.isAnswer == true && amCScript.isAnswer == true && amDScript.isAnswer == true && amEScript.isAnswer == true)
        {
            finalScore = amAScript.playerScore + amBScript.playerScore + amCScript.playerScore + amDScript.playerScore + amEScript.playerScore;
            if (finalScore >=  5)
            {
                Debug.Log("Good End!!");
                SceneManager.LoadScene("goodEnd");
            }
            else
            {
                Debug.Log("Bad End!!");
                SceneManager.LoadScene("badEnd");
            }
        }
    }
}
