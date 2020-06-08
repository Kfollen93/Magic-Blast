using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float t;
    public Text timerText;
    private float startTime;
    bool isTimerStopped = false;
    GameObject target;
    public Text highscore;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //best time
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            highscore.text = "Best Time: " + PlayerPrefs.GetFloat("Highscore").ToString();
        }
        else
        {
            highscore.text = "Best Time?";
        }

        // timer
        target = GameObject.FindWithTag("Target");
        if (target != null && !isTimerStopped)
        {
            startTime = Time.time;
        }
        else if (target == null)
        {
            isTimerStopped = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && !isTimerStopped)
        {
            t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
        else if (target == null)
        {
            isTimerStopped = true;
            SetHighscore();
        }
    }
    public void SetHighscore()
    {
        if (t < PlayerPrefs.GetFloat("Highscore") || (PlayerPrefs.HasKey("Highscore") == false))
        {
            PlayerPrefs.SetFloat("Highscore", t = Mathf.Round(t * 100f) / 100f);
            highscore.text = "Best Time: " + PlayerPrefs.GetFloat("Highscore").ToString();
        }
    }
}
