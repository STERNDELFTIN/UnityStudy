using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3; // 총알 이동속도
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향 구하기
        Vector3 dir = Vector3.up;
        // 이동 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
