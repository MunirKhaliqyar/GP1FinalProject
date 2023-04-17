using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    //public Transform bulletSpawnPoint;
    //public GameObject bulletPrefab;

    public float moveSpeed = 1f;
    // public float bulletSpeed = 1f;
    public float rotateSpeed = 12f;

    private void Update()
    {
        float moveVector = Input.GetAxisRaw("Vertical");
        float rotateVector = Input.GetAxisRaw("Horizontal");

        this.transform.Translate(0f, - moveVector * moveSpeed * Time.deltaTime, 0f);
        this.transform.Rotate(0f, 0f, - rotateVector * (rotateSpeed * 10) * Time.deltaTime);
        // Shooting();
    }

    /*
    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
   */
}
