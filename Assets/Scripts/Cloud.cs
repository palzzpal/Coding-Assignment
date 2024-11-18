using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-11f, 11f), Random.Range(-7f, 7f), 0);
        float randomValue = Random.Range(0.2f, 1f);
        transform.localScale = new Vector3(1, 1, 1) * randomValue;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, Random.Range(0.1f, 0.75f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
