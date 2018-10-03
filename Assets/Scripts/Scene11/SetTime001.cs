using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SetTime001 : MonoBehaviour {

    public Text timeText;
    public Text jump;
    public int point2, point3;
    public GameObject winPicture;
    public GameObject player;
    public GameObject ghost1, ghost2;
    public GameObject board1, board2;
    public GameObject star2, star3;

    private float Timer;
    private bool flag1, flag2, playeractive;

	void Start()
	{
        Timer = 60.0f;
        flag1 = true;
        flag2 = true;
        playeractive = false;
	}

	void Update()
	{
        Timer -= Time.deltaTime;
        SetTimeText();
        if (Timer <= 0)
        {
            if (!player.gameObject.activeInHierarchy && !playeractive)
            {
                StartCoroutine(restart());
            }
            else
            {
                playeractive = true;
                StartCoroutine(NextLevel());
            }
        }
        if (flag1 && Timer<=40) {
            board1.SetActive(true);
            flag1 = false;
        }
        if (flag2 && Timer<=20) {
            board2.SetActive(true);
            flag2 = false;
        }
	}

	void SetTimeText()
    {
        if (Timer < 0f) {
            Timer = 0f;
        }
        timeText.text = "Time: " + Timer.ToString(".000") + "s";
    }

    IEnumerator NextLevel() {
        ghost1.SetActive(false);
        ghost2.SetActive(false);
        winPicture.SetActive(true);
        jump.text = "Jumps: " + CountJumps.jumps.ToString();
        player.SetActive(false);
        if (Level01Data.stars[0] == 0) {
            Level01Data.stars[0] = 1;
        }
        yield return new WaitForSeconds(1.25f);
        if (CountJumps.jumps >= point2) {
            star2.SetActive(true);
            if (Level01Data.stars[0] <= 1)
            {
                Level01Data.stars[0] = 2;
            }
            yield return new WaitForSeconds(1.25f);
        }
        if (CountJumps.jumps >= point3)
        {
            star3.SetActive(true);
            Level01Data.stars[0] = 3;
            yield return new WaitForSeconds(1.25f);
        }
        Level01Data.totalStars = 0;
        for (int i = 0; i <= 5; i++) {
            Level01Data.totalStars += Level01Data.stars[i];
        }
        yield return new WaitForSeconds(2.75f);
        SceneManager.LoadScene(3);
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }
}
