using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet;
    //public GameObject enemyBulletClone;

    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyTimeToMove();
        
    }
    void EnemyTimeToMove()
    {
        // this if will pause the game when player got hit by enemy fire
        if (GameManager.playGame)
        {
            // move down after 13 movements one direction
            if (numOfMovements == 13)
            {
                transform.Translate(new Vector3(0, -1, 0));
                numOfMovements = -1;
                speed = -speed;
                timer = 0;
            }
            // move sideways on time interval
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < 13)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                numOfMovements++;
            }
            EnemyFire();
        }
       
        
    }
    void EnemyFire()
    {
        if (Random.Range(0f, 500f) < 1)
        {
            GameObject bullet = Instantiate(enemyBullet, this.transform.position, transform.rotation);
            Destroy(bullet, 1.4f);
        }
    }
}
