using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;

        if (x == 1)
        {
            Debug.Log("1�� ���� �����߽��ϴ�");
        }
        else if (x == 2)
        {
            Debug.Log("2�� ���� �����߽��ϴ�");
        }
        else if(x == 3)
        {
            Debug.Log("3�� ���� �����߽��ϴ�");
        }
        else if(x == 4)
        {
            Debug.Log("4�� ���� �����߽��ϴ�");
        }
        else
        {
            Debug.Log("�߸������߽��ϴ�");
        }
    }
}
