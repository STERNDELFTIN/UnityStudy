using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // ���� �ȿ� �ٸ� ��ü�� ������ ���
    private void OnTriggerEnter(Collider other)
    {
        // �� ��ü�� ����
        Destroy(other.gameObject);
    }
}
