using UnityEngine;

public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        if (first > second)
        {
            Debug.Log($"ū��:{first}");
        }
        else
        {
            Debug.Log($"ū��:{second}");
        }
    }
}
