using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuController : MonoBehaviour
{
    public GameObject escape;
    private bool EscapeMenuOpen;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EscapeMenuOpen == false)
            {
                EscapeMenuOpen = true;
                escape.gameObject.SetActive(true);
            }
            else
            {
                EscapeMenuOpen = false;
                escape.gameObject.SetActive(false);
            }
        }
    }



}