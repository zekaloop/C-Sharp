using UnityEngine;

//Integer : ������ ����
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = -2147483648;
        int max = 2147483647;

        Debug.Log("int ������ �ּҰ� =" + min);
        Debug.Log("int ������ �ִ밪 =" + max);
    }
}
