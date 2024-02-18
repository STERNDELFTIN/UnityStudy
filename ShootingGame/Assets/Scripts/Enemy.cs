using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir; // ������ ���� ������ ����� Start�� Update���� ���
    // Start is called before the first frame update
    void Start()
    {
        // Vector3 dir; // ����
        // 0���� 9���� 10���� �� �߿� �ϳ��� �������� ������
        int randValue = UnityEngine.Random.Range(0, 10);
        // ���� 3���� �۴ٸ� �÷��̾� ����
        if (randValue < 3)
        {
            // �÷��̾ ã�� target���� ��
            GameObject target = GameObject.Find("Player");
            // ������ ���ϰ� ����. target - me
            dir = target.transform.position - transform.position;
            // ������ ũ�⸦ 1��
            dir.Normalize();
        }
        // �׷��� �ʴٸ� �Ʒ� ����
        else dir = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 dir = Vector3.down; // ����

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
