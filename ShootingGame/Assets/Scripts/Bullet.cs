using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3; // �Ѿ� �̵��ӵ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���ϱ�
        Vector3 dir = Vector3.up;
        // �̵� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
