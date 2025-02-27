using UnityEngine;


// Log : 프로그램의 결과를 콘솔창에 출력
public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hi World");

        UnityEngine.Debug.Log("Hello Computer");

        Debug.Log("결과는 " + 5);

        Debug.Log("결과는 " + (5+10));

        Debug.Log("결과는: " + 5 + 10);
    }
}
