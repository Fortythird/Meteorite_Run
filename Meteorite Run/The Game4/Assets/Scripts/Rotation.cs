using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public GameObject Enemy1, Enemy2, Enemy3, player;
    private float speed = 0.8f;
    private Vector3 desiredRot, target;

	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y == 0 && player)
        {
            Enemy1.transform.Rotate(new Vector3(0, 0, 1));
            Enemy2.transform.Rotate(new Vector3(0, 0, 2.2f));
            Enemy3.transform.Rotate(new Vector3(0, 0, -1.7f));
        }
    }
}
