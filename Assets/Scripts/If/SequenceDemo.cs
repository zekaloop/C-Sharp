using UnityEngine;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;
        double avg = 0.0;

        total = kor + eng;
        avg = total / 2.0;

        Debug.Log($"����: {total}");
        Debug.Log($"���: {avg}");
    }
}

/*
  ��� : ���α׷��� �帧(����)�� ���ϴ� ����
- ������ : ������ �Ʒ��� ������� ��ɹ��� ����
- ���ǹ� : (if-else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� �����մϴ�
- �ݺ��� :
 */
