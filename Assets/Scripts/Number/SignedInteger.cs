using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sbyte iSbyte = 127; //8��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; //16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647; //32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036854775807; //64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyte: " + iSbyte);
        Debug.Log("short: " + iInt16);
        Debug.Log("int: " + iInt32);
        Debug.Log("long: " + iInt64);



        byte iByte = 255; //8��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535; //16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        uint iUInt32 = 4294967295; //32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        ulong iUInt64 = 18446744073709551615; //64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte: " + iByte);
        Debug.Log("ushort: " + iUInt16);
        Debug.Log("uint: " + iUInt32);
        Debug.Log("ulong: " + iUInt64);


    }
}


/*
Bit : 0,1
Byte : 0000 0000 

8Bit
(+, -)
sbyte : -128 ~ 127

(+, 0)
byte  : 0 ~ 255




SignedInteger (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)


UnSignedInteger (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��)


 */
