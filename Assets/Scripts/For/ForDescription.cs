using UnityEngine;

public class ForDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("�ȳ��ϼ���");
        }
    }
}

//for(�ʱ��; ���ǽ�; ������)
//�ʱ��: ���ǽĿ��� ����ϴ� ������ �ʱⰪ ����(�ʱ�ȭ)
//���ǽ�: ���ǽ� ��, �������� �Ǻ�, ���̸� �ڵ��� �ȿ��ִ� �ݺ� ���๮�� ����, �����̸� for���� ����
//������: �ݺ����� �����Ҷ� ���� ������ ���� ���ǽĿ��� ����ϴ� ������ ���� �ٽ� �������ִ� ��