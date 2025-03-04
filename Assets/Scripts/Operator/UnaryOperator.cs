using UnityEngine;

//UnaryOperator (단항연산자) : +, -
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 value 선언하고 0으로 초기화
        int value = 0;

        value = 8; //value 변수에 8값을 저장 => 8
        value = +value;
        Debug.Log(value);

        value = -8;
        value = +value;
        Debug.Log(value);


        value = 8;
        value = -value;
        Debug.Log(value);

        value = -8;
        value = -value;
        Debug.Log(value);
    }
}
