using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 10;
        if(x == 10)
        {
            Debug.Log("x�� 10�Դϴ�");
        }
        if(x != 20)
        {
            Debug.Log("x�� 20�� �ƴմϴ�");
        }


    }
}
