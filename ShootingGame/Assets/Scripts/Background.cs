using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial; // 배경 머터리얼
    public float scrollSpeed = 0.2f; // 스크롤 속도

    void Update()
    {
        // 방향
        Vector2 direction = Vector2.up;

        // 스크롤
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
