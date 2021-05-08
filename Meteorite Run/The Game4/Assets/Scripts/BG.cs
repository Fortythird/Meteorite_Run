using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {

    private bool bUFO = false, bShuttle = false, speedplus = false;
    public GameObject UFO, Shuttle, player, canvas;
    private float speed = 3f;
    private int score, ver;
    private Vector2 desiredPosUFO, desiredPosShuttle;


    // Use this for initialization
    void Start () {
        UFO.transform.position = new Vector2(UFO.transform.position.x, -4f);
        Shuttle.transform.position = new Vector2(Shuttle.transform.position.x, -4f);
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y == 0 && player)
        {
            RandomEnemySpawn var = canvas.GetComponent<RandomEnemySpawn>();
            score = var.Points;
            if (!bUFO || !bShuttle)
            {
                ver = UnityEngine.Random.Range(0, 2000);
                if (ver == 43 && !bUFO)
                {
                    bUFO = true;
                    UFO.transform.position = new Vector2(UnityEngine.Random.Range(-1.6f, 1.6f), 10f);
                    desiredPosUFO = new Vector2(UnityEngine.Random.Range(-1.6f, 1.6f), -4f);
                }
                if (ver == 1200 && !bShuttle)
                {
                    bShuttle = true;
                    Shuttle.transform.position = new Vector2(UnityEngine.Random.Range(-1.6f, 1.6f), 10f);
                    desiredPosShuttle = new Vector2(UnityEngine.Random.Range(-1.6f, 1.6f), -4f);
                }
            }
            if (UFO.transform.position.y > -4f) UFO.transform.position = Vector2.MoveTowards(UFO.transform.position, desiredPosUFO, speed * Time.deltaTime);
            else bUFO = false;
            if (Shuttle.transform.position.y > -4f) Shuttle.transform.position = Vector2.MoveTowards(Shuttle.transform.position, desiredPosShuttle, speed * Time.deltaTime);
            else bShuttle = false;
            if (score % 10 == 0 && score != 0 && speedplus == true && speed < 14f)
            {
                speed = speed + score / 40f;
                speedplus = false;
            }
            else if (score % 10 != 0) speedplus = true;
        }
    }
}
