using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //現在のステージ
    public int stageNum;
    //StageClaer時に生成するCanvas
    public GameObject StageClearCanvas;

    //残機
    private int remain = 2;

    public void Awake()
    {
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    //以下に処理を書く
    void Start()
    {
      Debug.Log("始まったよ");
    }

    //ステージクリア時に呼び出される関数
    public void StageClaer()
    {
      //表示されるTextの取得
      Text stageclearText = StageClearCanvas.transform.Find("Text").GetComponent<Text>();
      //表示されるTextを入力
      stageclearText.text = "Stage" + stageNum + "\nClear";

      //Canvasごとクリア時のTextを生成する
      GameObject _clearcanvas = Instantiate(StageClearCanvas, new Vector3(0, 0, 0), Quaternion.identity);

      //stageNumを1増やす
      stageNum++;
    }
}
