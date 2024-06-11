using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    //GameManager
  private GameObject _gameManagerObject;
  GameManager GMScript;

  void Start()
  {
    //GameManagerを取得
    _gameManagerObject = GameObject.Find("GameManager");
    GMScript = _gameManagerObject.GetComponent<GameManager>();
  }

  //当たり判定を取得
  void OnTriggerEnter2D(Collider2D t)
  {
    if(t.CompareTag("Player"))
    {
      Debug.Log("落ちたで");
      GMScript.PlayerFailed();
    }
  }
}
