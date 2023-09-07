using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerBar;

    [SerializeField] private float countdown;
    [SerializeField] private float countdownSpeed;

    public static event Action<int> changeSpeed;

    
    void Update()
    {
        timerBar.rectTransform.localScale = new Vector3(countdown, timerBar.rectTransform.localScale.y);

        if (countdown <= 0f)
        {
            countdown = 0.8f;
            changeSpeed.Invoke(0);
        }

        countdown -= countdownSpeed * Time.deltaTime;
    }
}
