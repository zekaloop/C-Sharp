using UnityEngine;

public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //���ǽ� 2��
        if (number == 1234 && number >= 1000)
        { 
                Debug.Log("�½��ϴ�");
        }

        if(number == 1234 || number <= 1000)
        {
            Debug.Log("����");
        }
    }
}
