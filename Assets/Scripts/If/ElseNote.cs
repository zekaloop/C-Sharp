using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            Debug.Log("���ǽ��� ���̸� ���๮1�� �����մϴ�");
        }
        else
        {
            Debug.Log("���ǽ��� �����̸� ���๮2�� �����մϴ�");
        }
    }
}
