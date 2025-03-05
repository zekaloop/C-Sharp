using UnityEngine;

public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //조건식 2개
        if (number == 1234 && number >= 1000)
        { 
                Debug.Log("맞습니다");
        }

        if(number == 1234 || number <= 1000)
        {
            Debug.Log("실행");
        }
    }
}
