using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour {

    public int record;
    private int score;
    public GameObject canvas;
    public Text MaxScore;

    // Use this for initialization
    void Start () {
        GameObject canvas = GameObject.Find("Mechanics");
    }
	
	// Update is called once per frame
	void Update () {
        RandomEnemySpawn var = canvas.GetComponent<RandomEnemySpawn>();
        score = var.Points;
        if (score > record) record = score;
        MaxScore.text = record.ToString();
	}
}
