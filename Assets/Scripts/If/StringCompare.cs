using UnityEngine;

//문자열 비교
public class StringCompare : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hi";
        string s2 = "Hi";

        if(s1 == s2)
        {
            Debug.Log("Same");
        }

        bool bln = false;

        if (bln == false)
        {
            Debug.Log("bln: " + bln);
        }

        if(!bln)
        {
            Debug.Log("!bln: " + !bln);
        }
    }
}
