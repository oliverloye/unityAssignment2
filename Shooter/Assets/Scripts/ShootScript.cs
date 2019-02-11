using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Rigidbody bullet;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    public void Fire()
    {
        if(bullet != null)
        {
            Rigidbody newBullet = (Rigidbody)Instantiate(bullet, transform.position, Quaternion.identity);
            newBullet.velocity = transform.forward * bulletSpeed;
        }
    }
}
