using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private Collider groundCollider;  //接地判定用のトリガーコリダー
    private void Start()
    {
        groundCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(groundCollider.isTrigger)
        {
            Debug.Log("接地しています。");  //接触している場合の処理
        }
        else
        {
            Debug.Log("接地していません。");  //接触していない場合の処理
        }
        
    }
}
