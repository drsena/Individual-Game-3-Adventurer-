using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Data : MonoBehaviour {

    static public int totalStars = 0;
    static public int[] stars = new int[6] { 0, 0, 0, 0, 0, 0 };

    private int lastFrameStars;

    public GameObject star1_1, star1_2, star1_3;
    public GameObject star2_1, star2_2, star2_3;
    public GameObject star3_1, star3_2, star3_3;
    public GameObject star4_1, star4_2, star4_3;
    public GameObject star5_1, star5_2, star5_3;
    public GameObject star6_1, star6_2, star6_3;

	void Update () {
        if (lastFrameStars!=totalStars) {
            if (stars[0] == 1) {
                star1_1.SetActive(true);
            } else if (stars[0] == 2)
            {
                star1_2.SetActive(true);
            } else if (stars[0] == 3)
            {
                star1_3.SetActive(true);
            }
            if (stars[1] == 1)
            {
                star2_1.SetActive(true);
            }
            else if (stars[1] == 2)
            {
                star2_2.SetActive(true);
            }
            else if (stars[1] == 3)
            {
                star2_3.SetActive(true);
            }
            if (stars[2] == 1)
            {
                star3_1.SetActive(true);
            }
            else if (stars[2] == 2)
            {
                star3_2.SetActive(true);
            }
            else if (stars[2] == 3)
            {
                star3_3.SetActive(true);
            }
            if (stars[3] == 1)
            {
                star4_1.SetActive(true);
            }
            else if (stars[3] == 2)
            {
                star4_2.SetActive(true);
            }
            else if (stars[3] == 3)
            {
                star4_3.SetActive(true);
            }
            if (stars[4] == 1)
            {
                star5_1.SetActive(true);
            }
            else if (stars[4] == 2)
            {
                star5_2.SetActive(true);
            }
            else if (stars[4] == 3)
            {
                star5_3.SetActive(true);
            }
            if (stars[5] == 1)
            {
                star6_1.SetActive(true);
            }
            else if (stars[5] == 2)
            {
                star6_2.SetActive(true);
            }
            else if (stars[5] == 3)
            {
                star6_3.SetActive(true);
            }
        }
        lastFrameStars = totalStars;
	}
}
