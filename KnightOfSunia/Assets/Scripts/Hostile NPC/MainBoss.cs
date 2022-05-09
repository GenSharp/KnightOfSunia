using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBoss : MonoBehaviour
{

    public int health;
    public GameObject spawnEnemy;
    public GameObject spawnLeuone;
    public float spawningDelay;
    public bool canSpawn = true;
    public bool canSpawnLeuone = false;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(Spawn());
        }

        if (health <= 50 && canSpawnLeuone)
        {
            canSpawnLeuone = true;
            StartCoroutine(SpawnLeuone());
        }

        else if (health <= 0)
        {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Spawn()
    {
        canSpawn = false;
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(spawningDelay);
        canSpawn = true;
    }

    public IEnumerator SpawnLeuone()
    {
        Instantiate(spawnLeuone, transform.position, Quaternion.identity);
        canSpawnLeuone = false;
        yield return new WaitForEndOfFrame();
    }

    public IEnumerator Death()
    {
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
        yield return new WaitForEndOfFrame();

    }
}
