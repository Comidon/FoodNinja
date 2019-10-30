using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float remainingTime = 300f;
    [SerializeField]
    private Text timeText;

    private int intTime;

    private void Update()
    {
        intTime = (int)System.Math.Ceiling(remainingTime);
        if (remainingTime > 0)
        {
            if(intTime % 60 == 0)
                timeText.text = (intTime / 60).ToString() + ":00";
            else
                timeText.text = (intTime / 60).ToString() + ":" + (intTime % 60).ToString();

            remainingTime -= Time.deltaTime;
        }
        else
        {
            timeText.text = "0:00";
            SceneManager.LoadScene("Dynamic UI");
        }
    }
}
