using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class FinishGame : MonoBehaviour {

    public GameObject player, ghost;
    public GameObject winPic, losePic;
    public Text collectCount;
    public int point2, point3;
    public GameObject star2, star3;

    private int collected;

	void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Enemy") {
            player.SetActive(false);
            ghost.SetActive(false);
            losePic.SetActive(true);
            StartCoroutine(Restart());
        } else if (other.gameObject.tag == "Player") {
            player.SetActive(false);
            ghost.SetActive(false);
            StartCoroutine(Pass());
        }
	}

    IEnumerator Restart() {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(11);
    }

    IEnumerator Pass() {
        winPic.SetActive(true);
        collected = ControlPlayer.Points06;
        collectCount.text = "Collected: " + collected.ToString();
        if (Level01Data.stars[5] == 0)
        {
            Level01Data.stars[5] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (collected >= point2)
        {
            star2.SetActive(true);
            if (Level01Data.stars[5] <= 1)
            {
                Level01Data.stars[5] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (collected >= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[5] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++)
        {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        SceneManager.LoadScene(0);
    }
}
