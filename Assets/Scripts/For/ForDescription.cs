using UnityEngine;

public class ForDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("안녕하세요");
        }
    }
}

//for(초기식; 조건식; 증감식)
//초기식: 조건식에서 사용하는 변수의 초기값 설정(초기화)
//조건식: 조건식 참, 거짓으로 판별, 참이면 코드블록 안에있는 반복 실행문을 실행, 거짓이면 for문을 종료
//증감식: 반복문을 실행할때 마다 실행한 직후 조건식에서 사용하는 변수의 값을 다시 연산해주는 식