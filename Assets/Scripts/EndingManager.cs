using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        amAScript = amA.GetComponent<AnswerManagerScript>();
        amBScript = amB.GetComponent<AnswerManagerScript>();
        amCScript = amC.GetComponent<AnswerManagerScript>();
        amDScript = amD.GetComponent<AnswerManagerScript>();
        amEScript = amE.GetComponent<AnswerManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (amAScript.isAnswer == true && amBScript.isAnswer == true && amCScript.isAnswer == true && amDScript.isAnswer == true && amEScript.isAnswer == true)
        {
            finalScore = amAScript.playerScore + amBScript.playerScore + amCScript.playerScore + amDScript.playerScore + amEScript.playerScore;
            if (finalScore >=  5)
            {
                Debug.Log("Good End!!");
            }
            else
            {
                Debug.Log("Bad End!!");
            }
        }
    }
}
