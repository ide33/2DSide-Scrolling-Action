using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f; // ジャンプの強さ
    private int jumpCount = 0; // ジャンプの回数
    private bool isGrounded = false; // 地面にいるかどうか
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // スペースキーが押され、ジャンプ回数が2未満の場合ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); // 上向きの速度をリセット
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse); // ジャンプの力を加える
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 地面に着地したらジャンプ回数をリセット
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // 地面から離れたら地面にいないことを設定
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
