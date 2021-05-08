using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingBG : MonoBehaviour {

    public GameObject BG1, BG2;
    private float speed = 1f;
    private Vector2 desiredPosition1, desiredPosition2;

	// Use this for initialization
	void Start () {
        desiredPosition1 = new Vector2(BG1.transform.position.x, -10);
        desiredPosition2 = new Vector2(BG2.transform.position.x, -10);
    }
	
	// Update is called once per frame
	void Update () {
        BG1.transform.position = new Vector3(BG1.transform.position.x, BG1.transform.position.y, 5f);
        BG2.transform.position = new Vector3(BG2.transform.position.x, BG2.transform.position.y, 5f);
        if (BG1.transform.position.y > -9f) BG1.transform.position = Vector2.MoveTowards(BG1.transform.position, desiredPosition1, speed * Time.deltaTime);
        else BG1.transform.position = new Vector2(BG1.transform.position.x, 13f);
        if (BG2.transform.position.y > -9f) BG2.transform.position = Vector2.MoveTowards(BG2.transform.position, desiredPosition2, speed * Time.deltaTime);
        else BG2.transform.position = new Vector2(BG2.transform.position.x, 13f);
    }
}
