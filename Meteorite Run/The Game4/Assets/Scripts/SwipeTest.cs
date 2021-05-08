using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{

    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    private bool check = false;


    // Use this for initialization
    void Start()
    {
        desiredPosition = new Vector3(0, 0, player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // if (swipeControls.SwipeLeft)
        //     desiredPosition += Vector3.left;
        //if (swipeControls.SwipeRight)
        //     desiredPosition += Vector3.right;


        if (check == false)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
            if (player.transform.position == desiredPosition) check = true;
        }
    }   
}