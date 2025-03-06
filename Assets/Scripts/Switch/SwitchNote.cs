using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;

        if (x == 1)
        {
            Debug.Log("1번 답을 선택했습니다");
        }
        else if (x == 2)
        {
            Debug.Log("2번 답을 선택했습니다");
        }
        else if(x == 3)
        {
            Debug.Log("3번 답을 선택했습니다");
        }
        else if(x == 4)
        {
            Debug.Log("4번 답을 선택했습니다");
        }
        else
        {
            Debug.Log("잘못선택했습니다");
        }
    }
}
