using System;
using UnityEngine;

public class MinValueFinder : MonoBehaviour
{
    void Start()
    {
        // ���� �迭�� �����մϴ�.
        int[] numbers = { 5, 3, 6, 8, 9 };

        // �ּҰ��� ã�� ���� ���� ����
        int minValue = numbers[0];

        // �迭�� ��ȸ�ϸ鼭 �ּҰ� ã��
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        // Unity �ֿܼ� �ּҰ� ���
        Debug.Log("�ּҰ�: " + minValue + " �Դϴ�");
    }
}
