using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangerChat : MonoBehaviour
{
    public GameObject chatBox;
    public Text chatText;
    public string dialogue;
    public bool playerInRange;

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown("e") &&
        if (playerInRange)
        {
            chatBox.SetActive(true);
            chatText.text = dialogue;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            chatBox.SetActive(false);
        }
    }
}
