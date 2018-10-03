using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Pass05 : MonoBehaviour
{
    static public bool hasPassed;

    public GameObject donut;
    public GameObject winPicture;
    public GameObject player;
    public Text timeCount;
    public int point2, point3;
    public GameObject star2, star3;

    private float timeConsumed;

    void Start()
    {
        hasPassed = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            donut.gameObject.SetActive(false);
            hasPassed = true;
            StartCoroutine(Pass());
        }
    }

    IEnumerator Pass()
    {
        winPicture.SetActive(true);
        timeConsumed = SetTime005.timer;
        timeCount.text = "Time: " + Mathf.FloorToInt(timeConsumed).ToString() + "s";
        player.SetActive(false);
        if (Level01Data.stars[4] == 0)
        {
            Level01Data.stars[4] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (timeConsumed <= point2)
        {
            star2.SetActive(true);
            if (Level01Data.stars[4] <= 1)
            {
                Level01Data.stars[4] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (timeConsumed <= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[4] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++)
        {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        hasPassed = false;
        SceneManager.LoadScene(11);
    }
}
