using UnityEditor;
using UnityEngine;


//Literal (��)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ���� ����� 
        int num;  //������ ����
        double su; //�Ǽ��� ����
        bool flag; //�ο��� ����
        string str; //���ڿ� ����
        char c; //������ ����

        //������ ���� ����
        num = 1234;
        su = 3.141592;
        flag = true;
        str = "�ȳ��ϼ�";
        c = 'a';

        //���� ����ϱ�
        Debug.Log("num : " + num);
        Debug.Log("su : " + su);
        Debug.Log("flag : " + flag);
        Debug.Log("str : " + str);
        Debug.Log("c : " + c);

    }
}
