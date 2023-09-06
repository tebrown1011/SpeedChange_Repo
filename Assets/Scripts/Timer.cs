using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerBar;

    [SerializeField] private float countdown;
    [SerializeField] private float countdownSpeed;

    public bool slowDown;

    
    void Update()
    {
        timerBar.rectTransform.localScale = new Vector3(countdown, timerBar.rectTransform.localScale.y);

        if(countdown <= 0f && slowDown == false)
        {
            slowDown = true;
            countdown = 0.8f;
        }
        else if (countdown <= 0f && slowDown == true)
        {
            slowDown = false;
            countdown = 0.8f;
        }

        countdown -= countdownSpeed * Time.deltaTime;
    }
}
