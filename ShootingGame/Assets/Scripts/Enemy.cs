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

        // �̵� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
    // �浹 �� �浹�ϸ� �ı�
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject); // �� �ı�
        Destroy(gameObject); // �� �ı�
    }
}
