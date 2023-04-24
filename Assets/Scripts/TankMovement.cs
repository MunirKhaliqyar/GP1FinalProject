using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] GameObject bulletPrefab;

    float nextShootTime = 0f;

    public float moveSpeed = 1f;
    public float bulletSpeed = 1f;
    public float rotateSpeed = 12f;

    void Update()
    {
        bool player1FireKey = Input.GetKeyDown(KeyCode.Space);
        bool player2FireKey = Input.GetKeyDown(KeyCode.M);

        if (transform.tag == "Player1")
        {
            float moveVector = Input.GetAxisRaw("Vertical");
            float rotateVector = Input.GetAxisRaw("Horizontal");

            this.transform.Translate(0f, - moveVector * moveSpeed * Time.deltaTime, 0f);
            this.transform.Rotate(0f, 0f, - rotateVector * (rotateSpeed * 10) * Time.deltaTime);
            Shooting(player1FireKey);
        }else if(transform.tag == "Player2")
        {
            float moveVector = Input.GetAxisRaw("Vertical2");
            float rotateVector = Input.GetAxisRaw("Horizontal2");

            this.transform.Translate(0f, -moveVector * moveSpeed * Time.deltaTime, 0f);
            this.transform.Rotate(0f, 0f, -rotateVector * (rotateSpeed * 10) * Time.deltaTime);
            Shooting(player2FireKey);
        } 
    }

    void Shooting(bool key)
    {
        if (key && Time.time > nextShootTime) 
        {
            nextShootTime = Time.time + 0.7f;
            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
            Rigidbody2D bulletRB = newBullet.gameObject.GetComponent<Rigidbody2D>();
            bulletRB.velocity = bulletSpawnPoint.transform.position * bulletSpeed;
        }
    }
   
}
