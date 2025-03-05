using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "괴발자";
        int age = 27;

        if (name == "괴발자" && age == 27)
        {
            Debug.Log($"이름은 {name} 나이는 {age}");
        }
    }
}
