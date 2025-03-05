using UnityEngine;

public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = 'n';
        
        if(input == 'y')
        {
            Debug.Log("YES");
        } else if(input == 'n')
        {
            Debug.Log("NO");
        }
        else
        {
            Debug.Log("CANCEL");
        }
    }
}
