using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pass02 : MonoBehaviour {

    static public bool hasPassed;

    public GameObject winPicture;
    public GameObject player;
    public Text timeCount;
    public int point2, point3;
    public GameObject star2, star3;

	void Start()
	{
        hasPassed = false;
	}


	private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hasPassed = true;
            StartCoroutine(Pass());
        }
    }

    IEnumerator Pass() {
        winPicture.SetActive(true);
        timeCount.text = "Time: " + Mathf.FloorToInt(ShowTime002.timer).ToString() + "s";
        player.SetActive(false);
        if (Level01Data.stars[1] == 0)
        {
            Level01Data.stars[1] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (ShowTime002.timer <= point2)
        {
            star2.SetActive(true);
            if (Level01Data.stars[1] <= 1)
            {
                Level01Data.stars[1] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (ShowTime002.timer <= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[1] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++)
        {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        hasPassed = false;
        SceneManager.LoadScene(5);
    }
}
