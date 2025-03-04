using UnityEngine;

public class IntParse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string strNumber = "1234";

        int number1 = System.Convert.ToInt32(strNumber);
        Debug.Log($"{number1} - {number1.GetTypeCode()}");

        int number2 = int.Parse(strNumber);
        Debug.Log($"{number2} - {number2.GetTypeCode()}");

        int number3 = System.Int32.Parse(strNumber);
        Debug.Log($"{number3} - {number3.GetTypeCode()}");

    }
}
