using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongJump : MonoBehaviour
{
     public float jumpForce = 10f; // ジャンプの基本的な力
    public float jumpTime = 0.5f; // 最大ジャンプ時間
    public float jumpMultiplier = 2f; // ジャンプボタンを長押ししたときの力の増加率

    private bool isJumping = false; // ジャンプ中かどうかを示すフラグ
    private float jumpTimeCounter; // 現在のジャンプ時間
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ジャンプボタンを押したとき
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        // ジャンプボタンを長押ししている間
        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * (jumpForce + (jumpMultiplier * (jumpTime - jumpTimeCounter)));
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        // ジャンプボタンを離したとき
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}
