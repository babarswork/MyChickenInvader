using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public Rigidbody2D bulletRb;
    public int speed = 6;
    public GameObject bulletpf;
    // Start is called before the first frame update
    void Start()
    {
        //bulletRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Moveup();
        
    }

    void Moveup()
    {
        // speed -ive becoz we have rottated the obj 180 to fire upward
        transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        //bulletRb.velocity = Vector2.up * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(bulletpf);
            GameManager.playGame = true;
        }
    }
}
