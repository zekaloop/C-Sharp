using UnityEngine;

// = AssignmentOperator(�Ҵ�(����) ������) ������ ���� �����Ѵ�
public class AssignmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "������"; //����, ����, �Ҵ�, �ʱ�ȭ
        int age = 19;

        Debug.Log($"�̸��� {name}, ���̴� {age}");
    }
}
