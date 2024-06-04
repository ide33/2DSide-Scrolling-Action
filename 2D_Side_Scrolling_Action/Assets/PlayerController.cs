using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// プレイヤー操作・制御クラス
/// </summary>
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;  //オブジェクト・コンポーネント参照
    private SpriteRenderer spriteRenderer;



    //移動関連変数
    [HideInInspector] public float xSpeed; //X方向移動速度
    [HideInInspector] public bool rightFacing;  //向いている方向(true.右向き false:左向き)

    void Start()  //Start(オブジェクト有効時に１度実行)
    {
        rigidbody2D = GetComponent<Rigidbody2D>();   //コンポーネント参照取得
        spriteRenderer = GetComponent<SpriteRenderer>();

        //変数初期化
        rightFacing = true;  //最初は右向き
    }

    void Update()  //Update(１フレームごとに１度ずつ実行)

    {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);  //プレイヤーの回転を停止させる
        MoveUpdate();  //左右移動処理
    }

    /// <summary>
    /// Updateから呼び出される左右移動入力処理
    /// </summary>
    private void MoveUpdate()
    {
        //X方向移動入力
        if (Input.GetKey(KeyCode.RightArrow))  //右方向の移動入力 
        {
            xSpeed = 6.0f;   //X方向移動速度をプラスに設定

            rightFacing = true;  //右向きフラグon
            spriteRenderer.flipX = false;  //スプライトを通常の向きで表示
        }
        else if (Input.GetKey(KeyCode.LeftArrow))  //左方向の移動入力
        {
            xSpeed = -6.0f;  //X方向移動をマイナスに設定

            rightFacing = false;  //右向きフラグoff
            spriteRenderer.flipX = true;  //スプライトを左右反転した向きで表示
        }
        else  //入力なし
        {
            xSpeed = 0.0f;  //X方向の移動を停止
        }
    }

    /// <summary>
    /// Updateから呼び出されるジャンプ入力処理
    /// </summary>

    private void FixedUpdate()  //FixedUpdate (一定時間ごとに１度ずつ実行・物理演算用)
    {
        Vector2 velocity = rigidbody2D.velocity;  //移動速度ベクトルを現在値から取得
        velocity.x = xSpeed;  //X方向の速度を入力から決定
        rigidbody2D.velocity = velocity;  //計算した移動速度ベクトルをRigidBody2Dに反映
    }


}