using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 80;
        int math = 90;
        int score = kor + math;
        double avg = score / 2;

        if (avg > 75)
        {
            Debug.Log("���հ�");
        }
        else if(avg == 50)
        {
            Debug.Log("�����");
        }
        else
        {
            Debug.Log("���հ�");
        }
    }
}
/*
if�� - ���ǹ�
���ǽ��� ���϶��� ���๮�� ����˴ϴ�
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�

���� ���ǽ��� ���̸� {}�ȿ� �ִ� ���๮�� �����϶�
if(���ǽ�)
{
    //���๮1
    //���๮2
    //...
}

if(bool)
{
    //���๮1
    //���๮2
    //...
}



 */