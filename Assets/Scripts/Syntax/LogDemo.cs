using UnityEngine;


// Log : ���α׷��� ����� �ܼ�â�� ���
public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hi World");

        UnityEngine.Debug.Log("Hello Computer");

        Debug.Log("����� " + 5);

        Debug.Log("����� " + (5+10));

        Debug.Log("�����: " + 5 + 10);
    }
}
