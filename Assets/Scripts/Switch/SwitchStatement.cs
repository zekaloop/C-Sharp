using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("���� ������ �����? (����, �帲, ��, ��)");
        string weather = "�帲";

        switch (weather)
        {
            case "����":
                Debug.Log("������ ���׿�");
                break;
            case "�帲":
                Debug.Log("������ �帮�׿�");
                break;
            case "��":
                Debug.Log("����� ì�⼼��");
                break;
            case "��":
                Debug.Log("������� ���弼��");
                break;
            default:
                Debug.Log("�߸������̳׿�");
                break;

        }

    }
}
