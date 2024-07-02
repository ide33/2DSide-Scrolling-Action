using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.CompareTag("Player"))
        {
            GameManager gamemanager = GameObject.FindObjectOfType<GameManager>();
            gamemanager.OnGoal();
        }
    }
}
