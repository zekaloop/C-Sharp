using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("¿À´Ã ³¯¾¾´Â ¾î¶²°¡¿ä? (¸¼À½, Èå¸², ºñ, ´«)");
        string weather = "Èå¸²";

        switch (weather)
        {
            case "¸¼À½":
                Debug.Log("³¯¾¾°¡ ¸¼³×¿ä");
                break;
            case "Èå¸²":
                Debug.Log("³¯¾¾°¡ Èå¸®³×¿ä");
                break;
            case "ºñ":
                Debug.Log("¿ì»êÀ» Ã¬±â¼¼¿ä");
                break;
            case "´«":
                Debug.Log("´«»ç¶÷À» ¸¸µå¼¼¿ä");
                break;
            default:
                Debug.Log("Àß¸ø´©¸£¼Ì³×¿ä");
                break;

        }

    }
}
