using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    private bool flag_time = false, flag = false;
    public GameObject Mech, Rot, title, timerGO, player;
    public Text timer;
    private float time = 0;
    private int t;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || flag_time == true) && player.transform.position.y == 0)
        {
            if (flag == false)
            {
                Mech.SetActive(false);
                Rot.SetActive(false);
                title.SetActive(true);
                time = 3;
            }
            if (flag == true)
            {
                flag_time = true;
                title.SetActive(false);
                time -= Time.deltaTime;
                if (time <= 0)
                {
                    Mech.SetActive(true);
                    Rot.SetActive(false);
                    timerGO.SetActive(false);
                }
                else
                {
                    timerGO.SetActive(true);
                    if (time > 2) timer.text = 3.ToString();
                    if (time <= 2 && time > 1) timer.text = 2.ToString();
                    if (time <= 1 && time > 0) timer.text = 1.ToString();
                    flag_time = !flag_time;
                }
                flag_time = !flag_time;
                flag = !flag;
            }
            flag = !flag;
        }
    }
}
