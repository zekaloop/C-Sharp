using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int input = 15;

        if(input % 2 == 0)
        {
            Debug.Log($"{input}�� ¦���Դϴ�");
        }
        else
        {
            Debug.Log($"{input}�� Ȧ���Դϴ�");
        }

        if(input % 5 == 0)
        {
            Debug.Log($"{input}�� 5�ǹ���Դϴ�");
        }else if(input % 3 == 0)
        {
            Debug.Log($"{input}�� 3�� ����Դϴ�");
        }
        else if(input % 7 == 0)
        {
            Debug.Log($"{input}�� 7�ǹ���Դϴ�");
        }
        else
        {
            Debug.Log($"{input}�� 3 5 7�� ����� �ƴմϴ�");
        }
    }
}
