using UnityEngine;

public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            if(i % 2 == 0)
            {
                sum = sum + i;
            }
        }    Debug.Log($"짝수의 합은{sum}입니다");
    }
}
