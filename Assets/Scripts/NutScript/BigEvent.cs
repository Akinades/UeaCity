using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigEvent : MonoBehaviour
{
    public string[] Question;
    public string[] Ans1;
    public string[] Ans2;
    public int Set;
    [Header("Text")]
    public Text TextQuestion;
    public Text TextAns1;
    public Text TextAns2;
    [Header("Button")]
    public Button AnsCorrect;
    public Button AnsWrong;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Set)
        {

            case 0:
                TextQuestion.text = Question[0];
                TextAns1.text = Ans1[0];
                TextAns2.text = Ans2[0];
                break;
            case 1:
                TextQuestion.text = Question[1];
                TextAns1.text = Ans1[1];
                TextAns2.text = Ans2[1];
                break;
            case 2:
                TextQuestion.text = Question[2];
                TextAns1.text = Ans1[2];
                TextAns2.text = Ans2[2];
                break;
            case 3:
                TextQuestion.text = Question[3];
                TextAns1.text = Ans1[3];
                TextAns2.text = Ans2[3];
                break;
            case 4:
                TextQuestion.text = Question[4];
                TextAns1.text = Ans1[4];
                TextAns2.text = Ans2[4];
                break;
            case 5:
                TextQuestion.text = Question[5];
                TextAns1.text = Ans1[5];
                TextAns2.text = Ans2[5];
                break;

        }
    }
    public void SetQuestion(int number)
    {
        Set = number;
    }
}
