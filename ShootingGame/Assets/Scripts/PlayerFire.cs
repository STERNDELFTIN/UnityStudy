using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // �Ѿ��� ������ ����
    public GameObject firePosition; // �ѱ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ��ǥ : ������ �߻� ��ư�� ������ �Ѿ��� �߻�
        // 1. ����ڰ� �߻� ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // �Ѿ� ���忡�� �Ѿ��� ����
            GameObject bullet = Instantiate(bulletFactory);
            // �Ѿ� �߻� (�Ѿ��� �ѱ� ��ġ�� �����ٳ���)
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
