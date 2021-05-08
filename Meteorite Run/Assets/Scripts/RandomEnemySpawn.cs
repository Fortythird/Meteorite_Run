using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour {

    private int rand1, rand2, rand3, k = 0, lives = 3, var = 0, ver1 = 0, ver2 = 0;
    public int Points = 0;
    private float speed = 5f;
    private Vector2 desiredPosition, desiredPositionClone, desiredPosition3;
    public GameObject Enemy1, player, GO, Enemy2, Enemy3, PS;
    public GameObject health1, health2, health3;
    private bool speedplus = false;

    void Start () {
        desiredPositionClone = new Vector2(Enemy2.transform.position.x, -4f);
        var = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y == -2f && player)
        {
            if (Points > 19 && ver1 == 0) ver1 = UnityEngine.Random.Range(1, 5);
            if (Points > 49 && ver2 == 0) ver2 = UnityEngine.Random.Range(10, 20);
            if (k < 1 && ver1 != 3 && ver2 != 15)
            {
                rand1 = UnityEngine.Random.Range(0, 3);
                if (var < 2)
                {
                    if (rand1 == 1)
                    {
                        Enemy1.transform.position = new Vector2(-1.6f, 10f);
                    }
                    if (rand1 == 0)
                    {
                        Enemy1.transform.position = new Vector2(0, 10f);
                    }
                    if (rand1 == 2)
                    {
                        Enemy1.transform.position = new Vector2(1.6f, 10f);
                    }
                }
                else
                {
                    Enemy1.transform.position = new Vector2(player.transform.position.x, 10f);
                    var = 0;
                }
                k++;
                if ((Mathf.Abs(Enemy1.transform.position.x - player.transform.position.x)) > 1) var++; // Random correction
                else var = 0;
            }
            if (ver1 == 3 && k < 1 && ver2 != 15)
            {
                rand1 = UnityEngine.Random.Range(0, 3);
                rand2 = rand1;
                while (rand1 == rand2)
                {
                    rand2 = UnityEngine.Random.Range(0, 3);
                }
                if (rand1 == 1)
                {
                    Enemy1.transform.position = new Vector2(-1.6f, 10f);
                }
                if (rand1 == 0)
                {
                    Enemy1.transform.position = new Vector2(0, 10f);
                }
                if (rand1 == 2)
                {
                    Enemy1.transform.position = new Vector2(1.6f, 10f);
                }
                if (rand2 == 1)
                {
                    Enemy2.transform.position = new Vector2(-1.6f, 10f);
                }
                if (rand2 == 0)
                {
                    Enemy2.transform.position = new Vector2(0, 10f);
                }
                if (rand2 == 2)
                {
                    Enemy2.transform.position = new Vector2(1.6f, 10f);
                }
                k += 2;
            }
            if (ver2 == 15 && k < 1)
            {
                rand1 = UnityEngine.Random.Range(0, 3);
                rand2 = UnityEngine.Random.Range(0, 3);
                while (rand1 == rand2)
                {
                    rand2 = UnityEngine.Random.Range(0, 3);
                }
                rand3 = UnityEngine.Random.Range(0, 3);
                while (rand2 == rand3)
                {
                    rand3 = UnityEngine.Random.Range(0, 3);
                }
                if (rand1 == 1)
                {
                    Enemy1.transform.position = new Vector2(-1.6f, 10f);
                }
                if (rand1 == 0)
                {
                    Enemy1.transform.position = new Vector2(0, 10f);
                }
                if (rand1 == 2)
                {
                    Enemy1.transform.position = new Vector2(1.6f, 10f);
                }
                if (rand2 == 1)
                {
                    Enemy2.transform.position = new Vector2(-1.6f, 15f);
                }
                if (rand2 == 0)
                {
                    Enemy2.transform.position = new Vector2(0, 15f);
                }
                if (rand2 == 2)
                {
                    Enemy2.transform.position = new Vector2(1.6f, 15f);
                }
                if (rand3 == 1)
                {
                    Enemy3.transform.position = new Vector2(-1.6f, 20f);
                }
                if (rand3 == 0)
                {
                    Enemy3.transform.position = new Vector2(0, 20f);
                }
                if (rand3 == 2)
                {
                    Enemy3.transform.position = new Vector2(1.6f, 20f);
                }
                k += 3;
            }
            desiredPosition = new Vector2(Enemy1.transform.position.x, -6f);
            desiredPositionClone = new Vector2(Enemy2.transform.position.x, -6f);
            desiredPosition3 = new Vector2(Enemy3.transform.position.x, -6f);
            Enemy1.transform.position = Vector2.MoveTowards(Enemy1.transform.position, desiredPosition, speed * Time.deltaTime);
            Enemy2.transform.position = Vector2.MoveTowards(Enemy2.transform.position, desiredPositionClone, speed * Time.deltaTime);
            Enemy3.transform.position = Vector2.MoveTowards(Enemy3.transform.position, desiredPosition3, speed * Time.deltaTime);
            if (ver2 == 15 && Enemy3.transform.position.y <= -6f)
            {
                Points++;
                ver1 = 0;
                ver2 = 0;
                k--;
            }
            if (ver1 == 3 && Enemy2.transform.position.y <= -6f)
            {
                Points++;
                ver1 = 0;
                ver2 = 0;
                k--;
            }
            if (Enemy1.transform.position.y <= -6f)
            {
                Points++;
                ver1 = 0;
                ver2 = 0;
                k--;
            }
            if ((Mathf.Abs(Enemy1.transform.position.x - player.transform.position.x))<1 && Mathf.Abs(Enemy1.transform.position.y - player.transform.position.y) < 0.5f)
            {
                if (lives == 3) health3.SetActive(false);
                if (lives == 2) health2.SetActive(false);
                if (lives == 1)
                {
                    health1.SetActive(false);
                    Destroy(player);
                    Destroy(Enemy1);
                    Destroy(Enemy2);
                    Destroy(Enemy3);
                    GO.SetActive(true);
                }
                k--;
                Enemy1.transform.position = new Vector2(Enemy1.transform.position.x, -6f);
                lives--;
                ver1 = 0;
                ver2 = 0;
                PS.SetActive(false);
                PS.SetActive(true);
            }
            if ((Mathf.Abs(Enemy2.transform.position.x - player.transform.position.x)) < 1 && Mathf.Abs(Enemy2.transform.position.y - player.transform.position.y) < 1f)
            {
                if (lives == 3) health3.SetActive(false);
                if (lives == 2) health2.SetActive(false);
                if (lives == 1)
                {
                    health1.SetActive(false);
                    Destroy(player);
                    Destroy(Enemy2);
                    Destroy(Enemy1);
                    Destroy(Enemy3);
                    GO.SetActive(true);
                }
                k--;
                lives--;
                ver1 = 0;
                ver2 = 0;
                Enemy2.transform.position = new Vector2(Enemy2.transform.position.x, -6f);
                PS.SetActive(false);
                PS.SetActive(true);
            }
            if ((Mathf.Abs(Enemy3.transform.position.x - player.transform.position.x)) < 1 && Mathf.Abs(Enemy3.transform.position.y - player.transform.position.y) < 1f)
            {
                if (lives == 3) health3.SetActive(false);
                if (lives == 2) health2.SetActive(false);
                if (lives == 1)
                {
                    health1.SetActive(false);
                    Destroy(player);
                    Destroy(Enemy2);
                    Destroy(Enemy1);
                    Destroy(Enemy3);
                    GO.SetActive(true);
                }
                k--;
                lives--;
                ver1 = 0;
                ver2 = 0;
                Enemy3.transform.position = new Vector2(Enemy3.transform.position.x, -6f);
                PS.SetActive(false);
                PS.SetActive(true);
            }
            if (Points % 10 == 0 && Points != 0 && speedplus == true && speed < 14f)
            {
                speed = speed + Points / 40f;
                speedplus = false;
            }
            else if (Points % 10 != 0) speedplus = true;
        }
    }
}
