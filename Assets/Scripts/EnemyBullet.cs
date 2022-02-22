using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int speed = 4;
    public GameObject enemyBulletpf;
    Vector2 reSpawn = new Vector2(7, 4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDownFire();
    }
    void MoveDownFire()
    {
        transform.Translate(new Vector2(0, -speed * Time.deltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = reSpawn;
            Destroy(enemyBulletpf);
            GameManager.lives--;
            GameManager.playGame = false;
        }
    }
}
