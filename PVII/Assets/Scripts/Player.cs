using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float lives = 5f;


    public void ModifyLives(float amount)
    {
        lives += amount;

        if (lives <= 0)
        {
            lives = 0;
            Debug.Log("GAME OVER");
        }
        else
        {
            Debug.Log("Lives: " + lives);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Goal")) { return; }

        Debug.Log("WIN");
    }
}
