using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePostion : MonoBehaviour
{
    public GameObject bulletPrefab;
    

    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }
    public void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, this.transform.position, transform.rotation);
            Destroy(bullet, 1.5f);
        }
    }
    
}
