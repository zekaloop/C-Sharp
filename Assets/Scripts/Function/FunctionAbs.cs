using UnityEngine;

// abs(���밪)�� ���ϴ� �Լ� �����
//
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number);

        Debug.Log($"{number}�� ���밪�� {abs}");
    }

    //�Ű������� ���� ������ ���밪�� ��ȯ�ϴ� �Լ�
    int Abs(int num)
    {
        /*if(num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        } */
        return (num < 0) ? -num : num;
    }
}
