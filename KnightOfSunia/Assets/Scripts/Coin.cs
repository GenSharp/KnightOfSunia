using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    int value = 0;
    public static bool isPickuUp = false;

    // Start is called before the first frame update
    void Start()
    {
        value = Random.Range(1, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Money.money += value;
            isPickuUp = true;
            Destroy(gameObject);
        }
    }
}
