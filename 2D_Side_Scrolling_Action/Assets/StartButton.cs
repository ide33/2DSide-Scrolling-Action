using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
    }


    void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
