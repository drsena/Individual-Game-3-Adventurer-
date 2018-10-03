using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetTime005 : MonoBehaviour
{

    static public float timer;

    public Text timeText;

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        if (!Pass05.hasPassed)
        {
            timer += Time.deltaTime;
            SetTimeText();
        }
    }

    void SetTimeText()
    {
        timeText.text = "Time: " + timer.ToString(".000") + "s";
    }
}
