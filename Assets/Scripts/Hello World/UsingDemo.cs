// using ����Ҷ�
/*
using UnityEngine;

public class UsingDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame

}
*/
// using ������� ������
public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //NameSpace.Class.Method();
        UnityEngine.Debug.Log("Hello World");
    }

    // Update is called once per frame

}