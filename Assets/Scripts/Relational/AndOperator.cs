using UnityEngine;


//AndOperator(And ������) : && �Ѵ� ���϶��� ��
//��� : true, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�Ѵ� ���϶��� ��
        Debug.Log(true && true);

        //���߿� �ϳ��� �����̶�� ����
        Debug.Log(true && false);
        Debug.Log(false && true);

        //�Ѵ� �����̸� ����
        Debug.Log(false && false);
    }
}
