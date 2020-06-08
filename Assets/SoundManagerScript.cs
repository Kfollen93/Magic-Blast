using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip shootSound, backgroundSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        backgroundSound = Resources.Load<AudioClip>("Soundtrack");
        audioSrc = GetComponent<AudioSource>();
    }
   

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(audioSrc);

        if (Input.GetKeyDown("space"))
        {
            shootSound = Resources.Load<AudioClip>("shootSound");
        }
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "shootSound":
                audioSrc.PlayOneShot(shootSound);
                break;

            case "Soundtrack":
                audioSrc.PlayOneShot(backgroundSound);
                break;
        }
    }
}
