using UnityEngine;

// bool: ����, ���ڷ���, ��(true), ����(false) ���� ����
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool ���� �����ϰ� �ʱ�ȭ
        bool bln = true;
        Debug.Log("bln: " + bln);

        bool isOut = false;
        Debug.Log("isOut: " + isOut);
    }
}
