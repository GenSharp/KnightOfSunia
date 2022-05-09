using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteraction : MonoBehaviour
{

    public TextMeshProUGUI tekstOdNpca;
    public GameObject odg1;
    public GameObject odg2;
    public GameObject zavrKonv;
    public GameObject npcInteraction;
    public GameObject quest;
    public GameObject questItem;
    bool isCollision = false;
    bool doneQuest = false;

    // Start is called before the first frame update
    void Start()
    {
        tekstOdNpca.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isCollision && Quest.questCounter == 0)
        {
            npcInteraction.SetActive(true);
            tekstOdNpca.text = "Hello there, my name is Matej, would you like to help me out with something?";
        }

        else if (Input.GetKeyDown(KeyCode.E) && isCollision && Quest.questCounter == 5)
        {
            npcInteraction.SetActive(true);
            quest.SetActive(false);
            tekstOdNpca.text = "Thank you very much! Here you go, a 100 gold.";
            Money.money += 100;
            doneQuest = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !doneQuest)
        {
            isCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isCollision = false;
            npcInteraction.SetActive(false);
        }
    }

    public void Odg1()
    {
        tekstOdNpca.text = "I want you to collect 5 axes that have been stolen from me. I will pay you well.";
        odg2.SetActive(true);
        odg1.SetActive(false);
    }

    public void Odg2()
    {
        tekstOdNpca.text = "You will get your reward once you come back with my 5 axes.";
        odg2.SetActive(false);
        quest.SetActive(true);
        questItem.SetActive(true);
    }

    public void ZavrKonv()
    {
        isCollision = false;
        npcInteraction.SetActive(false);
    }
}
