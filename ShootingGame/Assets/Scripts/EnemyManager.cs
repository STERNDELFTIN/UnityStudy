using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // ���� �ð�
    float currentTime;
    // ���� �ð�
    public float createTime = 1;
    // �� ����
    public GameObject enemyFactory;

    // �ּ� �ð�
    float minTime = 1;
    // �ִ� �ð�
    float maxTime = 5;

    void Start()
    {
        // �¾ �� ���� ���� �ð� ����
        // �¾ �� �� �� �����ϰ� ���� �¾ �� �ٽ� ����
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update()
    {
        // �ð��� �帧
        currentTime += Time.deltaTime;

        // ���� ���� �ð��� ���� �ð��� �ʰ��ϸ�
        if (currentTime > createTime)
        {
            // �� ���忡�� ���� ����
            GameObject enemy = Instantiate(enemyFactory);
            // �� ��ġ�� ���ٳ���
            enemy.transform.position = transform.position;

            // ���� �ڵ������ �ۼ��ϸ� ���� �ð��� ���� �ð��� �ǰ� �� �� ��� ���� �ð����� ũ�� ������ ���� ��� ����
            // ���� �Ʒ� �ڵ带 �����Ͽ� ���� �ð��� ���� �ð����� Ŀ���� �� ���� �ð��� 0���� �ʱ�ȭ
            currentTime = 0;

            // �� ���� �� ���� ���� �ð��� �ٽ� ����
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}