using UnityEngine;


//2���� �迭 : ��� ���� �̷���� �迭

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�迭 ����
        int[,] intArray;

        //[2]�迭 ��Ҽ�(ũ��) ����
        intArray = new int[2, 3];

        //[3]�迭 �ʱ�ȭ
        //0����
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        //1����
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        //[4]�迭 ���
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j<3; j++)
            {
                Debug.Log(intArray[i, j]);
            }
            Debug.Log("  ");
        }

    }
}
