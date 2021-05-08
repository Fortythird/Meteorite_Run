using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningRotation : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player.transform.Rotate(new Vector3(0, 0, 0.5f));
    }
}
