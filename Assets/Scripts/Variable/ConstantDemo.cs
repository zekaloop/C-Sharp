using UnityEngine;


//Constant(���) = ������ �ʴ� ����, �б�����
public class ConstantDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //���� ������ ��� ����� ���ÿ� �ʱ�ȭ
       const int MAX = 100;

        //��� ����ϱ�
        Debug.Log("�ִ밪: " + MAX);
    }
}
