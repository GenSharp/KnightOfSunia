using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Loot
{
    public GameObject item;
    [Range(0.01f, 100f)]
    public float dropRate;
    public int minQuantity;
    public int maxQuantity;
}

public class ObjectDropItems : MonoBehaviour
{

    public Loot[] loots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) //samo test
        {
            DropItem();
        }
    }

    public void DropItem()
    {
        foreach (Loot loot in loots)
        {
            float spawnChance = Random.Range(-0.01f, 100f);
            if (spawnChance <= loot.dropRate)
            {
                int spawnAmount = Random.Range(loot.minQuantity, loot.maxQuantity);
                for (int i = 0; i < spawnAmount; i++)
                {
                    GameObject currentDrop = Instantiate(loot.item, transform.position, transform.rotation * Quaternion.identity);
                    //currentDrop.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 10), ForceMode2D.Impulse);
                }
            }
        }
    }
}
