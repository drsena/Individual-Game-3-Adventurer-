using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pass00 : MonoBehaviour {

    public Button b11, b12, b13, b14, b15, b16, b17, bquit;
    public Text totalStars;
    public int starsToPass;

    void Start()
    {
        b17.interactable = false;

        Button btn1 = b11.GetComponent<Button>();
        Button btn2 = b12.GetComponent<Button>();
        Button btn3 = b13.GetComponent<Button>();
        Button btn4 = b14.GetComponent<Button>();
        Button btn5 = b15.GetComponent<Button>();
        Button btn6 = b16.GetComponent<Button>();
        Button btnquit = bquit.GetComponent<Button>();
        Button btn7 = b17.GetComponent<Button>();

        btn1.onClick.AddListener(TaskOnClick1);
        btn2.onClick.AddListener(TaskOnClick2);
        btn3.onClick.AddListener(TaskOnClick3);
        btn4.onClick.AddListener(TaskOnClick4);
        btn5.onClick.AddListener(TaskOnClick5);
        btn6.onClick.AddListener(TaskOnClick6);
        btnquit.onClick.AddListener(TaskOnClickQuit);
        btn7.onClick.AddListener(TaskOnClick7);
    }

	void Update()
	{
        if (Level01Data.totalStars >= starsToPass) {
            b17.interactable = true;
        }
        totalStars.text = "★: " + Level01Data.totalStars.ToString() + "/" + starsToPass.ToString();
	}

	void TaskOnClick1()
    {
        SceneManager.LoadScene(1);
    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene(3);
    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene(5);
    }

    void TaskOnClick4()
    {
        SceneManager.LoadScene(7);
    }

    void TaskOnClick5()
    {
        SceneManager.LoadScene(9);
    }

    void TaskOnClick6()
    {
        SceneManager.LoadScene(11);
    }

    void TaskOnClickQuit()
    {
        Application.Quit();
    }

    void TaskOnClick7()
    {
        SceneManager.LoadScene(13);
    }
}
