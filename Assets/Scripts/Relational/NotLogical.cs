using UnityEngine;

// NotOperator (부정 연산자, Not) : ! 참이면 거짓이고, 거짓이면 참으로 변환
// 결과는 true, false
public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //참일때
        Debug.Log(!true); // false

        //거짓일때
        Debug.Log(!false); // true

        bool bln = false;
        Debug.Log(!bln); //true
        Debug.Log(!!bln); //false
        Debug.Log(!(!(!bln))); //true
    }
}
