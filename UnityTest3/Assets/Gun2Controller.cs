using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2Controller : MonoBehaviour
{
    GameObject player;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �ѱ��� Player�� �������� �����ϱ� ���� Rotation ����.
        dir = player.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(dir);
    }
}
