using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("�ݸ޴��� �����Ͽ����ϴ�");
        }
        else if (score >= 80)
        {
            Debug.Log("���޴��� �����Ͽ����ϴ�");
        }
        else if (score >= 70)
        {
            Debug.Log("���޴��� �����Ͽ����ϴ�");
        }
        else
        {
            Debug.Log("��޴��Դϴ�");
        }
    }
}
