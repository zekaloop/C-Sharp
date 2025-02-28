using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홀수";
        const int num = 3;

        Debug.Log($"{num}"+ "은(는)"+ $"{name}"+"입니다");
    }
}
