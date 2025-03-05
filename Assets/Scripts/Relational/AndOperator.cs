using UnityEngine;


//AndOperator(And 연산자) : && 둘다 참일때만 참
//결과 : true, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //둘다 참일때만 참
        Debug.Log(true && true);

        //둘중에 하나라도 거짓이라면 거짓
        Debug.Log(true && false);
        Debug.Log(false && true);

        //둘다 거짓이면 거짓
        Debug.Log(false && false);
    }
}
