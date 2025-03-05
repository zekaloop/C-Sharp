using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 80;
        int math = 90;
        int score = kor + math;
        double avg = score / 2;

        if (avg > 75)
        {
            Debug.Log("괴합격");
        }
        else if(avg == 50)
        {
            Debug.Log("재시험");
        }
        else
        {
            Debug.Log("불합격");
        }
    }
}
/*
if문 - 조건문
조건식이 참일때만 실행문이 실행됩니다
조건식이 거짓이면 실행문은 실행하지 않습니다

만약 조건식이 참이면 {}안에 있는 실행문을 실행하라
if(조건식)
{
    //실행문1
    //실행문2
    //...
}

if(bool)
{
    //실행문1
    //실행문2
    //...
}



 */