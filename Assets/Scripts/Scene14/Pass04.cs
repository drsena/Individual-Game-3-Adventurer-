using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Pass04 : MonoBehaviour
{

    static public int remainingGhosts = 3;
    static public bool hasPassed;

    public GameObject winPicture;
    public GameObject player;
    public Text timeCount;
    public int point2, point3;
    public GameObject star2, star3;

    private float timeConsumed;

	void Start()
	{
        remainingGhosts = 3;
        hasPassed = false;
	}

	void Update()
	{
        if (remainingGhosts <= 0 && !hasPassed) {
            hasPassed = true;
            StartCoroutine(pass());
        }
	}

	IEnumerator pass()
    {
        yield return new WaitForSeconds(0.5f);
        winPicture.SetActive(true);
        timeConsumed = SetTime004.timer;
        timeCount.text = "Time: " + Mathf.FloorToInt(timeConsumed).ToString() + "s";
        player.SetActive(false);
        if (Level01Data.stars[3] == 0)
        {
            Level01Data.stars[3] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (timeConsumed <= point2)
        {
            star2.SetActive(true);
            if (Level01Data.stars[3] <= 1)
            {
                Level01Data.stars[3] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (timeConsumed <= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[3] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++)
        {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        SceneManager.LoadScene(9);
    }
}
