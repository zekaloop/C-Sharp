using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string medal = "";

        if (score >= 90)
        {
            medal = "금메달";
        }
        else if (score >= 80)
        {
            medal = "은메달";
        }
        else if (score >= 70)
        {
            medal = "동메달";
        }
        else
        {
            medal = "노메달";
        }
        Debug.Log($"{medal}을 수상하셨습니다");
    }
}
