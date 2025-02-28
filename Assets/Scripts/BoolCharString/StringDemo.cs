using UnityEngine;

//string(문자열) : 문자(배)열 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";

        Debug.Log("안녕하셈 " + name + "임");

        string multiLine = @"
            안녕하쇼
            반갑소
            
        ";

        Debug.Log(multiLine);

    }
}
