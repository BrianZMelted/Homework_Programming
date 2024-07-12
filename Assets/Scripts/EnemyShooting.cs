using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private GameObject player;
    private float timer;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position,player.transform.position);



        if (timer > 2)
        {
            timer = 0;
            shoot();
        }
    }


    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
