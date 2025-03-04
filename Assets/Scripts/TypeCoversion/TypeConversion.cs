using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // double�� �Ǽ��� ���� d�� �����ϰ� 12.34�� �ʱ�ȭ
        double d = 12.34;
        //int�� ������ ���� i�� �����ϰ� 1234�� �ʱ�ȭ
        int i = 1234;

        // double > int :������(�Ϲ���, �Ͻ���) ���� ��ȯ
        d = i;

        Debug.Log("�Ϲ��� ���ĺ�ȯ: " + d);

        d = 12.34;
        i = 1234;

        // int < double : ������� ���� ��ȯ �ʿ�
        i = (int)d;
        Debug.Log("������� ���ĺ�ȯ: " + i);

        d = 12.34;
        i = 1234;

        // �ٸ� ���İ��� ��ȯ
        string s = ""; //string ���� s�� �����ϰ� ""(��) ���� �ʱ�ȭ
        s = i.ToString();
        Debug.Log("�ٸ� ���ĺ�ȯ: " + s);
    }
}
