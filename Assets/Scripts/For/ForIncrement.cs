using UnityEngine;

public class ForIncrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 11; i = i + 2) 
        {
            Debug.Log(i);
        }    
    }
}
