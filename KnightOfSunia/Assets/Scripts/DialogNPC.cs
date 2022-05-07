using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogNPC : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI textDisplay;
    public GameObject continueButton;
    public static bool canType = false;
    public string[] sentences;
    public static int index;
    public float typingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //continueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canType)
        {
            StartCoroutine(Type());
            canType = false;
        }

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        else if (index == 0)
        {
            continueButton.SetActive(false);
        }
    }

    IEnumerator Type()
    {
        foreach  (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }

        else
        {
            textDisplay.text = "";
        }
    }
}
