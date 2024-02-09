using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // 총알을 생산할 공장
    public GameObject firePosition; // 총구

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 목표 : 유저가 발사 버튼을 누르면 총알을 발사
        // 1. 사용자가 발사 버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            // 총알 공장에서 총알을 만듦
            GameObject bullet = Instantiate(bulletFactory);
            // 총알 발사 (총알을 총구 위치로 가져다놓음)
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
