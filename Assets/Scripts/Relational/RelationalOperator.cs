using UnityEngine;

//RelationalOperator(������ ������, �� ������)
// < (����), <=(�۰ų� ����), >(ŭ), >=(ũ�ų� ����), ==(����), !=(�ٸ�)
// ��� : true(��), false(����)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);       //
        Debug.Log(x <= y);      // 
        Debug.Log(x > y);
        Debug.Log(x >= y);
        Debug.Log(x == y);
        Debug.Log(x != y);

        Debug.Log("AAA" == "aaa");
    }
}
