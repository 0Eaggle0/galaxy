using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Ship : MonoBehaviour
{
    public SpriteRenderer render_bullet;
    public int damage = 1;

    float speed_bullet = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed_bullet, 0);
        if (!ScreenUtils.isPosition_on_screen(transform.position)){
            Destroy(gameObject);
        }
    }
}
