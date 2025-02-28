using System;
using UnityEngine;

public class MinValueFinder : MonoBehaviour
{
    void Start()
    {
        // 숫자 배열을 선언합니다.
        int[] numbers = { 5, 3, 6, 8, 9 };

        // 최소값을 찾기 위한 변수 선언
        int minValue = numbers[0];

        // 배열을 순회하면서 최소값 찾기
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        // Unity 콘솔에 최소값 출력
        Debug.Log("최소값: " + minValue + " 입니다");
    }
}
