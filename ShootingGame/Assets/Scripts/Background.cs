using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial; // ��� ���͸���
    public float scrollSpeed = 0.2f; // ��ũ�� �ӵ�

    void Update()
    {
        // ����
        Vector2 direction = Vector2.up;

        // ��ũ��
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
