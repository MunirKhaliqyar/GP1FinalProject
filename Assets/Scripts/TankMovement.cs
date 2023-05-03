using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TankMovement : MonoBehaviour
{
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] ParticleSystem dustParticleSystem;
    [SerializeField] AudioSource bulletSound;

    HealthController healthController;
    

    [SerializeField] GameObject shotDirection;

    float nextShootTime = 0f;

    public float moveSpeed = 2f;
    public float bulletSpeed = 800f;
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
            bulletSound.Play();
            nextShootTime = Time.time + 0.7f;

            Vector3 bulletSpawnPositon = bulletSpawnPoint.position;
            Vector3 shotDirectionPosition = shotDirection.transform.position;
            Vector3 bulletDirection = shotDirectionPosition - bulletSpawnPositon;

            float angle = Vector2.Angle(bulletDirection, Vector3.up);

            if(bulletDirection.x > 0)
            {
                // fix the angle
                angle = 360 - angle;
            }

            Quaternion bulletRotation = Quaternion.AngleAxis(angle, Vector3.forward);

            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletRotation);

            Rigidbody2D bulletRB = newBullet.gameObject.GetComponent<Rigidbody2D>();

            bulletRB.velocity =  bulletDirection * bulletSpeed;
        }
    }
}
