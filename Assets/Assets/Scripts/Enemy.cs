using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject explosion;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.Find("GameManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            GameObject.Find("Player(Clone)").GetComponent<Player>().LoseALife();
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameManager.GetComponent<GameManager>().LoseLife();
            Destroy(this.gameObject);
        } else if (whatDidIHit.tag == "Weapon")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(5);
            Destroy(whatDidIHit.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
