using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifeTime : MonoBehaviour
{
    [SerializeField] float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
