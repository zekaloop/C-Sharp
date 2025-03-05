using UnityEngine;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;
        double avg = 0.0;

        total = kor + eng;
        avg = total / 2.0;

        Debug.Log($"총점: {total}");
        Debug.Log($"평균: {avg}");
    }
}

/*
  제어문 : 프로그램의 흐름(순서)를 정하는 구문
- 순차문 : 위에서 아래로 순서대로 명령문을 실행
- 조건문 : (if-else, switch) : 조건에 따른 서로 다른 명령문을 실행합니다
- 반복문 :
 */
