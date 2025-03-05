using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("금메달을 수상하였습니다");
        }
        else if (score >= 80)
        {
            Debug.Log("은메달을 수상하였습니다");
        }
        else if (score >= 70)
        {
            Debug.Log("동메달을 수상하였습니다");
        }
        else
        {
            Debug.Log("노메달입니다");
        }
    }
}
