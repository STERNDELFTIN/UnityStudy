using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir; // 방향을 전역 변수로 만들어 Start와 Update에서 사용
    public GameObject explosionFactory; // 폭발 공장 주소

    void Start()
    {
        // Vector3 dir; // 삭제
        // 0부터 9까지 10개의 값 중에 하나를 랜덤으로 가져옴
        int randValue = UnityEngine.Random.Range(0, 10);
        // 만약 3보다 작다면 플레이어 방향
        if (randValue < 3)
        {
            // 플레이어를 찾아 target으로 함
            GameObject target = GameObject.Find("Player");
            // 방향을 구하고 싶음. target - me
            dir = target.transform.position - transform.position;
            // 방향의 크기를 1로
            dir.Normalize();
        }
        // 그렇지 않다면 아래 방향
        else dir = Vector3.down;
    }
    void Update()
    {
        // Vector3 dir = Vector3.down; // 삭제

        // 이동 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
   
    // 충돌하면 폭발 효과 발생 및 파괴
    private void OnCollisionEnter(Collision other)
    {
        GameObject explosion = Instantiate(explosionFactory); // 폭발 효과 생성
        explosion.transform.position = transform.position; // 폭발 효과 위치(발생)

        Destroy(other.gameObject); // 너 파괴
        Destroy(gameObject); // 나 파괴
    }
}
