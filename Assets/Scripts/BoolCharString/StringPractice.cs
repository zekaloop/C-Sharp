using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "Ȧ��";
        const int num = 3;

        Debug.Log($"{num}"+ "��(��)"+ $"{name}"+"�Դϴ�");
    }
}
