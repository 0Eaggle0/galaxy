using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float speed = 0.1f;
    float damage = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, 0);
        if (!ScreenUtils.isPosition_on_screen(transform.position)){
            Destroy(gameObject);
        }
    }
}
