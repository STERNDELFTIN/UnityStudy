using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;

        // 이동 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
    // 충돌 및 충돌하면 파괴
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject); // 너 파괴
        Destroy(gameObject); // 나 파괴
    }
}
