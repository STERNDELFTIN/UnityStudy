using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // 현재 시간
    float currentTime;
    // 일정 시간
    public float createTime = 1;
    // 적 공장
    public GameObject enemyFactory;

    // 최소 시간
    float minTime = 1;
    // 최대 시간
    float maxTime = 5;

    void Start()
    {
        // 태어날 때 적의 생성 시간 설정
        // 태어날 때 한 번 설정하고 적이 태어날 때 다시 설정
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update()
    {
        // 시간이 흐름
        currentTime += Time.deltaTime;

        // 만약 현재 시간이 일정 시간을 초과하면
        if (currentTime > createTime)
        {
            // 적 공장에서 적을 생성
            GameObject enemy = Instantiate(enemyFactory);
            // 내 위치에 갖다놓기
            enemy.transform.position = transform.position;

            // 위의 코드까지만 작성하면 현재 시간이 일정 시간이 되고 난 후 계속 일정 시간보다 크기 때문에 적을 계속 생성
            // 따라서 아래 코드를 삽입하여 현재 시간이 일정 시간보다 커졌을 때 현재 시간을 0으로 초기화
            currentTime = 0;

            // 적 생성 후 적의 생성 시간을 다시 설정
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}