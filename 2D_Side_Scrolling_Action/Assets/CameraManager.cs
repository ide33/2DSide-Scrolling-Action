using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject terget;  //追従する対象を決める変数
    Vector3 pos;  //カメラの初期位置を記憶するための変数
    void Start()
    {
        pos = Camera.main.gameObject.transform.position;  //カメラの初期位置を変数posに入れる
    }

    void Update()
    {
       Vector3 camerapos = terget.transform.position;  //cameraposという変数を作り、追従する対象の位置を入れる
       if(terget.transform.position.x < 0)  //もし対象の横位置が0より小さい場合
       {
           camerapos.x = 0;  //カメラの位置に0を入れる
       }
       if(terget.transform.position.y < 0)  //もし対象の縦位置が0より小さい場合
       {
           camerapos.y = 0;  //カメラの縦位置に0を入れる
       }
       if(terget.transform.position.y > 0)  //もし対象の縦位置が0より大きい場合
       {
           camerapos.y = terget.transform.position.y;  //カメラの縦位置に対象の位置を入れる
       }
       camerapos.z = -10;  //カメラの奥行きの位置に-10を入れる
       Camera.main.gameObject.transform.position = camerapos;  //カメラの位置に変数cameraPosの位置を入れる
        
    }
}
