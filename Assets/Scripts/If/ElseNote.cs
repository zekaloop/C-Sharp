using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            Debug.Log("조건식이 참이면 실행문1을 실행합니다");
        }
        else
        {
            Debug.Log("조건식이 거짓이면 실행문2를 실행합니다");
        }
    }
}
