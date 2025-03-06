using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for(int i = 1; i< 101; i++)
        {
            if(i % 3 == 0 || i % 4 ==0)
            {
                sum =  sum + i;
            }
        }
        Debug.Log($"гую╨ {sum}");
    }
}
