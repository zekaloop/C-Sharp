using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int input = 15;

        if(input % 2 == 0)
        {
            Debug.Log($"{input}은 짝수입니다");
        }
        else
        {
            Debug.Log($"{input}은 홀수입니다");
        }

        if(input % 5 == 0)
        {
            Debug.Log($"{input}는 5의배수입니다");
        }else if(input % 3 == 0)
        {
            Debug.Log($"{input}는 3의 배수입니다");
        }
        else if(input % 7 == 0)
        {
            Debug.Log($"{input}는 7의배수입니다");
        }
        else
        {
            Debug.Log($"{input}은 3 5 7의 배수가 아닙니다");
        }
    }
}
