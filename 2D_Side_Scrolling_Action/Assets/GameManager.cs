using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject hpGauge;
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

       void Update()
    {
        
    }

    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
