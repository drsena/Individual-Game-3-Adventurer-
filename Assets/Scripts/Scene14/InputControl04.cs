using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputControl04 : MonoBehaviour {

    static public bool pressedE;
    public GameObject player;
    public GameObject particlePlayer;
    public float movementSpeed;
    public RawImage running;
    public Text runningT;
    public RawImage explode;
    public Text explodeE;

    private bool cdT, cdE;
    private float timerT, timerE;
    private float timeCDE = 28f;
    private float timeE = 4f;
    private bool firstT = true;

	void Start()
	{
        timerT = 20f;
        timerE = timeCDE - timeE;
        cdT = true;
        cdE = false;
        StartCoroutine(WaitCDE());
        pressedE = false;
	}

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && cdT == true)
        {
            cdT = false;
            Rigidbody rigid = player.GetComponent<Rigidbody>();
            rigid.AddRelativeForce(Vector3.forward * movementSpeed);
            StartCoroutine(WaitCDT());
        }
        if (!cdT) {
            timerT -= Time.deltaTime;
            SetTimeText();
        }

        if (Input.GetKeyDown(KeyCode.E) && cdE == true)
        {
            cdE = false;
            StartCoroutine(WaitCDE());
        }
        if (!cdE)
        {
            timerE -= Time.deltaTime;
            SetTimeTextE();
        }
    }

    IEnumerator WaitCDT() {
        running.gameObject.SetActive(false);
        yield return new WaitForSeconds(20f);
        cdT = true;
        running.gameObject.SetActive(true);
        timerT = 20f;
    }

    void SetTimeText()
    {
        if (timerT < 0f)
        {
            timerT = 0f;
        }
        runningT.text = Mathf.FloorToInt(timerT+1f).ToString();
    }

    IEnumerator WaitCDE()
    {
        explode.gameObject.SetActive(false);
        if (!firstT)
        {
            pressedE = true;
            particlePlayer.SetActive(true);
            yield return new WaitForSeconds(timeE);
            pressedE = false;
            particlePlayer.SetActive(false);
        }
        yield return new WaitForSeconds(timeCDE - timeE);
        cdE = true;
        explode.gameObject.SetActive(true);
        timerE = timeCDE;
        firstT = false;
    }

    void SetTimeTextE()
    {
        if (timerE < 0f)
        {
            timerE = 0f;
        }
        explodeE.text = Mathf.FloorToInt(timerE + 1f).ToString();
    }
}
