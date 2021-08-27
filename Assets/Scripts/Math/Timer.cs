using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private bool stopWatchActive = false;
    private float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopWatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartTimer()
    {
        stopWatchActive = true;
    }
    public void PauseTimer()
    {
        stopWatchActive = false;
    }

    public void PlayGame() {
        // Application.LoadLevel(0);
        SceneManager.LoadScene(0);
    }
}
