using UnityEngine;

public class VariableDefault : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� �����ϰ� default(�⺻��) ������ �ʱ�ȭ
        int i = default;
        double d = default;
        char c = default;
        string s = default;

        Debug.Log($"[{i}],[{d}],[{c == System.Char.MinValue}],[{s == null}]");
    }
}
