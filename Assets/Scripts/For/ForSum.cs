using UnityEngine;

public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        for(int i = 0; i <10000; i++)
        {
            sum += i;
            Debug.Log(sum);
        }
    }
}
