using UnityEngine;

public class FunctionDescription : MonoBehaviour
{
    //[1] Show �޼���(�Լ�) ����, ����
    void Show()
    {
        Debug.Log("Hello code");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show �Լ� ȣ��
        Show();

    }
}

/*
 Function(�Լ�) Method(�ż���)
:�ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ���

-���� �Լ� : ���(C#)���� �����ϴ� �Լ�, ����Ƽ���� �����ϴ� �Լ�
-����� �Լ� : �����ڰ� ����� �Լ�
 
- �Ű������� ���� �Լ�
- �Ű������� �ִ� �Լ�
- ��ȯ���� �ִ� �Լ�

void �Լ��̸�()
{
    //�ϳ� �̻��� ��ɹ�
    //.....
}
 
 
void �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
    //.....
}

(������ Ÿ��) �Լ��̸�(�Ű������� �������� �ְ� �������� �ִ�)
{
    //�ϳ� �̻��� ��ɹ�
    //.....

    
    return ����(��);

}

//�Լ� ����
�Է� -> ó��(����) -> ���


//�Լ�(�޼���)
[1] �Լ� ���� (��� ����)
[2] �Լ� ȣ�� (��� ���)
[]
 */
