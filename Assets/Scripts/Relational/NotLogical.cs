using UnityEngine;

// NotOperator (���� ������, Not) : ! ���̸� �����̰�, �����̸� ������ ��ȯ
// ����� true, false
public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���϶�
        Debug.Log(!true); // false

        //�����϶�
        Debug.Log(!false); // true

        bool bln = false;
        Debug.Log(!bln); //true
        Debug.Log(!!bln); //false
        Debug.Log(!(!(!bln))); //true
    }
}
