using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenQuestion : MonoBehaviour
{

    public Question oobject;

    public Text TextQuestion, TextAnswerOne, TextAnswerTwo;
    public GameObject ButtonOne,ButtonTwo;
    public Image imagecontaner;
    void Start()
    {
        UpdateUi();
    }
    public void UpdateUi()
    {

        TextQuestion.text = oobject.text;
        imagecontaner.sprite = oobject.Bckground;
        if (oobject.Answers.Length > 0)
        {
            ButtonOne.SetActive(true);
            TextAnswerOne.text = oobject.Answers[0].TitelForAnswer;
            if (oobject.Answers.Length == 2)
            {
                ButtonTwo.SetActive(true);
                TextAnswerTwo.text = oobject.Answers[1].TitelForAnswer;
            }
            else ButtonTwo.SetActive(false);

        }
        else
        {
            ButtonOne.SetActive(false);
            ButtonTwo.SetActive(false);
        }
    }


    public void OnClick(int index)
    {
        oobject = oobject.Answers[index];
        UpdateUi();
    }
}
