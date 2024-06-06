using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    
    public float maxJumpTime = 0.5f; // 最大ジャンプ時間（秒）
    public float flapForce = 500f; // ジャンプの力
    private float jumpTime = 0f; // 現在のジャンプ時間
    private bool isGround = true; // 地面にいるかどうか
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ジャンプボタンが押されている間
        if (Input.GetKey("space") && isGround)
        {
            // ジャンプ時間を計測
            jumpTime += Time.deltaTime;

            // ジャンプ時間が最大ジャンプ時間を超えないように制限
            jumpTime = Mathf.Clamp(jumpTime, 0f, maxJumpTime);
        }

        // ジャンプボタンが離されたとき
        if (Input.GetKeyUp("space") && isGround)
        {
            // ジャンプ処理
            Jump();
        }
    }

    void Jump()
    {
        // ジャンプの力を計算
        float jumpForce = CalculateJumpForce(jumpTime);
        rb2d.AddForce(Vector2.up * jumpForce);
    }

    float CalculateJumpForce(float time)
    {
        // ジャンプの力を調整する式（例）
        // ここで必要に応じて式を調整してください
        return flapForce * time / maxJumpTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpTime = 0f; // 地面に着地したらジャンプ時間をリセット
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
