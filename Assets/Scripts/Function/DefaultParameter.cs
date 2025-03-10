using UnityEngine;

//DefaultParameter(�⺻ �Ű�����, ������ �Ű�����) : �Ű����� �����Ҷ� ���ÿ� �ʱ�ȭ�� �Ѵ�
//������ �Ű������� �Լ� ȣ��� ������ �����ϴ�. ������ �ʱ�ȭ �� ���� ���Ǿ� ����
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //�Ű� ������ ���� �Լ� ȣ��
        PrintMessage();

        //�Ű� ������ �ִ� �Լ� ȣ��
        string error = "�����";
        PrintError(error);

        //��ȯ���� �ִ� �Լ� ȣ��
        string errorLog = PrintLog();
        Debug.Log(errorLog);
        */

        PrintError("�����", 4);
        PrintError("�����", 1);
    }

    //Message�� ����ϴ� �Լ�
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
    }

    void PrintError(string message, int level = 1)
    {
        Debug.Log($"����: {message}, ����: {level}");

    }

    string PrintLog()
    {
        string log = "�α�";
        return log;

    }
}
