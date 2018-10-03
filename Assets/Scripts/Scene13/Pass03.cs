using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pass03 : MonoBehaviour
{
    public GameObject winPicture;
    public GameObject player;
    public Text timesHit;
    public int point2, point3;
    public GameObject star2, star3;

    private int hit;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(pass());
        }
    }

    IEnumerator pass()
    {
        winPicture.SetActive(true);
        hit = ChasePlayer03.timesTouched;
        timesHit.text = "Times hit: " + hit.ToString();
        player.SetActive(false);
        if (Level01Data.stars[2] == 0)
        {
            Level01Data.stars[2] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (hit >= point2)
        {
            star2.SetActive(true);
            if (Level01Data.stars[2] <= 1)
            {
                Level01Data.stars[2] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (hit >= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[2] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++)
        {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        Deaths03.deaths = 0;
        ChasePlayer03.timesTouched = 0;
        SceneManager.LoadScene(7);
    }
}
