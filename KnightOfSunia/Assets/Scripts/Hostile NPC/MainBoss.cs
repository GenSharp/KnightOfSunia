using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBoss : MonoBehaviour
{
    public float health;
    public float Cooldown;
    public bool cooldown;
    public GameObject gobo;
    public int goblinspawn;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldown == true)
        {
            StartCoroutine(spawn());
        }
        if(goblinspawn>=25)
        {
            Destroy(gameObject);
        }


    }


    public IEnumerator spawn()
    {
        Instantiate(gobo, transform.position, Quaternion.identity);
        cooldown = false;
        yield return new WaitForSeconds(Cooldown);
        cooldown = true;
        goblinspawn = goblinspawn + 1;

    }


















}
