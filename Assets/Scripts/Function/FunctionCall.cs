using UnityEngine;

public class FunctionCall : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]�Լ� ȣ��(����ϱ�) : 3�� ȣ��
        Hi();
        Hi();
        Hi();
    }

    //[1] �Լ� �����(����,����)
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���");
    }
}
