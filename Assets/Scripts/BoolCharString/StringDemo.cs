using UnityEngine;

//string(���ڿ�) : ����(��)�� ������ ����
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿";

        Debug.Log("�ȳ��ϼ� " + name + "��");

        string multiLine = @"
            �ȳ��ϼ�
            �ݰ���
            
        ";

        Debug.Log(multiLine);

    }
}
