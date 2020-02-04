using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question",menuName = "Craeate New Question")]
public class Question : ScriptableObject
{
    public string TitelForAnswer;
    public string text;
    public Sprite Bckground;
    public Question[] Answers;
}
