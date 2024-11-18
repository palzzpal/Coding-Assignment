using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject gameManager;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.Find("GameManager");
        }
    }

    // Detect collision with the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Increase the player's score by 1
            gameManager.GetComponent<GameManager>().EarnScore(1);

            // Destroy the coin after it's collected
            Destroy(this.gameObject);
        }
    }
}
