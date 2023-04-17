using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotateSpeed = 12f;

    private void FixedUpdate()
    {
        float moveVector = Input.GetAxis("Vertical");
        float rotateVector = Input.GetAxis("Horizontal");

        this.transform.Translate(0f, moveVector * moveSpeed * Time.deltaTime, 0f);
        this.transform.Rotate(0f, 0f, -rotateVector * (rotateSpeed * 10) * Time.deltaTime);
    }
}
