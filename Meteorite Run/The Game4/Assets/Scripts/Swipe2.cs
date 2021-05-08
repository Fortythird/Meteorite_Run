using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe2 : MonoBehaviour
{ 

    private int pos;
    private bool Check, Move;
    private float x1, x2;
    private float speed = 30f;
    private bool begin = false;
    private bool end = false;
    private Vector3 Right, Left, Center;
    // Use this for initialization
    void Start()
    {
        pos = 0;
        Move = true;
        Right = new Vector3(1.6f, 0, player.transform.position.z);
        Center = new Vector3(0, 0, player.transform.position.z);
        Left = new Vector3(-1.6f, 0, player.transform.position.z);
    }

    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (Move)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Check = true;
                if (!begin)
                {
                    x1 = Input.mousePosition.x;
                    begin = true;
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                Check = false;
                if (!end)
                {
                    x2 = Input.mousePosition.x;
                    end = true;
                }
                Move = false;
            }
        }
        if (!Check)
        {
            if (x2 - x1 > 50)
                if (pos < 1)
                {
                    if (pos == -1)
                    {
                        player.transform.position = Vector2.MoveTowards(player.transform.position, Center, speed * Time.deltaTime);
                        if (player.transform.position.x >= Center.x)
                        {
                            pos++;
                            Move = true;
                        }
                    }
                    if (pos == 0)
                    {
                        player.transform.position = Vector2.MoveTowards(player.transform.position, Right, speed * Time.deltaTime);
                        if (player.transform.position.x >= Right.x)
                        {
                            pos++;
                            Move = true;
                            player.transform.position = Right;
                        }
                    }
                    if ((pos == 0) && (Move)) player.transform.position = Center;
                    if ((pos == 1) && (Move)) player.transform.position = Right;
                }
            if (x2 - x1 < -50)
                if (pos > -1)
                {
                    if (pos == 1)
                    {
                        player.transform.position = Vector2.MoveTowards(player.transform.position, Center, speed * Time.deltaTime);
                        if (player.transform.position.x <= Center.x)
                        {
                            pos--;
                            Move = true;
                        }
                    }
                    if (pos == 0)
                    {
                        player.transform.position = Vector2.MoveTowards(player.transform.position, Left, speed * Time.deltaTime);
                        if (player.transform.position.x <= Left.x)
                        {
                            pos--;
                            Move = true;
                        }
                    }
                    if ((pos == 0) && (Move)) player.transform.position = Center;
                    if ((pos == -1) && (Move)) player.transform.position = Left;
                }
            if ((x2 - x1 < -50) && (pos == -1)) Move = true;
            if ((x2 - x1 > 50) && (pos == 1)) Move = true;
            if (Mathf.Abs(x1 - x2) < 50) Move = true;
            if (Move)
            {
                begin = false;
                end = false;
                Check = true;
            }
        }
    }
}