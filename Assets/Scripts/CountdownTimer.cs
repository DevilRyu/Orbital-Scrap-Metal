using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (currentTime == 60)
        {
            countdownText.text = "1 : " + currentTime.ToString("0");
        }
        else if(currentTime>=10)
        {
            countdownText.text = "0 : " + currentTime.ToString("0");
        }
        else
        {
            countdownText.text = "0 : 0" + currentTime.ToString("0");
        }
        currentTime -= 1 * Time.deltaTime;
        


        //print(currentTime);
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
