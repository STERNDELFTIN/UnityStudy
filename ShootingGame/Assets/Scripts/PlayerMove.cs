using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5; // 플레이어가 이동할 속력
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // print("h : " + h + "v : " + v);

        // 방향
        // Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        // transform.Translate(dir * speed * Time.deltaTime);
        transform.position += dir * speed * Time.deltaTime;

        // 이동
        // transform.Translate(Vector3.right * speed * Time.deltaTime);
        // transform.Translate(Vector3.left * 5 * Time.deltaTime);
        // right, left, up, down, forward, back
    }
}
