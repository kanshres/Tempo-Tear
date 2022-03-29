using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // Music Variables
    public AudioSource audioSource;
    public float startTime;
    public float endTime;

    // Level Variables
    public static int level;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.time = startTime;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(audioSource.time);
        if (audioSource.time > endTime)
        {
            audioSource.Stop();
        }

        // Check what level is currently being played
        if (SceneManager.GetActiveScene().name == "Level01")
        {
            level = 1;
        }
        else if (SceneManager.GetActiveScene().name == "Level02")
        {
            level = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Level03")
        {
            level = 3;
        }
    }
}