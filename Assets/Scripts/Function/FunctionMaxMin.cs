using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = GetMin(-3, -5);
        Debug.Log($"-3 �� -5�� ���� ���� {min}�̴� ");
    }
    int GetMin(int x,int y)
    {
        if(x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

/*
        int maxValue;
        if(x > y)
        {
            maxValue = x;
        }
        else
        {
            maxValue = y;
        }
        return maxValue;
        
        //3�� ������
        int maxValue = (x > y) ? x : y;
        return maxValue;
        

        //return (x > y) ? x : y;
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
        */
