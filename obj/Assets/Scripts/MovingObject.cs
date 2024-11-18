using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public int myType;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myType == 1)
        {
            //I am a bullet
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 10f);
        } else if (myType == 2) {
            //I am enemy
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        } else if (myType == 3)
        {
            // I am a cloud
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Random.Range(2f, 6f) * gameManager.cloudSpeed);
        } else if (myType == 4)
        {
            // I am a coin
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        } else if (myType == 5)
        {
           //I am Powerup
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 6f);
        }

        if ((transform.position.y > 9f ||  transform.position.y <= -9f) && myType !=3)
        {
            Destroy(this.gameObject);
        } else if (transform.position.y <= -9f && myType == 3)
        {
            transform.position = new Vector3(Random.Range(-10f, 10f), 9f, 0);
        }
    }
}
