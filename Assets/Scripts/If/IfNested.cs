using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "������";
        int age = 27;

        if (name == "������" && age == 27)
        {
            Debug.Log($"�̸��� {name} ���̴� {age}");
        }
    }
}
