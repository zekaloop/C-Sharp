using UnityEngine;

//LogicalOperator
//OrOperator (Or ������): || �ϳ��� ���̸� ��
//��� : true, false
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�Ѵ� ���϶�
        Debug.Log(true || true); //true

        //���߿� �ϳ��� ���϶�
        Debug.Log(true || false);   //true
        Debug.Log(false || true);   //true

        //�Ѵ� �����̸�
        Debug.Log(false || false);  //false
    }
}
