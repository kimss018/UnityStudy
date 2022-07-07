using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robotRD;
    public float walkSpeed = 10.0f;
    public float jumpSpeed = 10.0f;

    Animator animator;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        robotRD = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = false;


        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.0f)
        {
            isMoving = true;
            // Walk �ִϸ��̼� ����.
            animator.SetBool("isWalking", true);

            // �����̵�
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

            // �ڷ� ����
            transform.localScale = new Vector2(-2.0f, 2.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.0f)
        {
            isMoving = true;
            // Walk �ִϸ��̼� ����.
            animator.SetBool("isWalking", true);

            // ������ �̵�
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);

            // �ڷ� ����
            transform.localScale = new Vector2(2.0f, 2.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump �ִϸ��̼� ����
            animator.SetTrigger("jumpTrigger");

            // ����
            // transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime);
            robotRD.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);


        }

        if (!isMoving)
        {
            // Walk �ִϸ��̼� ����.
            animator.SetBool("isWalking", false);
        }

        
    }
}
