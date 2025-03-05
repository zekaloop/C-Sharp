using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 10;
        if(x == 10)
        {
            Debug.Log("x는 10입니다");
        }
        if(x != 20)
        {
            Debug.Log("x는 20이 아닙니다");
        }


    }
}
