using UnityEngine;

public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]�Ű� ������ �ִ� �Լ� ȣ��(���)�ϱ�
        ShowMessage("�ȳ��ϼſ�");
        ShowMessage("�ȳ�");

    }

    //[1] �Ű������� �ִ� �Լ� ����(�����ϱ�)
    //�Ű������� ���� ���� ���ڿ��� ���
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
