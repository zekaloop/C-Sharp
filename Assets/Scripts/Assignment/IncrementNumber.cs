using UnityEngine;

//정수형 변수의 값을 1 증가
public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 10;
        num = num + 1; 
        Debug.Log(num);
    }
}
