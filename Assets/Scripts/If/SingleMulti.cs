using UnityEngine;

// 실행문: 단문(1), 복문(2)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //단문
        if (1 == 1)
        {
            Debug.Log("단문");
        }

        if (1 == 1)
            Debug.Log("단문 2");

        if (1 == 1) Debug.Log("단문 3");


        // 복문 (실행문이 2개 이상일때)
        if (1 == 1)
        {
            Debug.Log("복문 1");
            Debug.Log("복문 2");
        }
    }
}
