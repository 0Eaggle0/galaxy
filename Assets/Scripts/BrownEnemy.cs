using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class BrownEnemy : MonoBehaviour
{
    public int health = 2;
    private SpriteRenderer sprite_renderer;
    private float halfwidth;
    public GameObject Enemy_bullet_original;
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
        halfwidth = sprite_renderer.bounds.size.x / 2;
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider){
        GameObject objectEnemy = collider.gameObject;
        Bullet_Ship bullet_script = objectEnemy.GetComponent<Bullet_Ship>();
        if (bullet_script != null){
            health -= bullet_script.damage;
            if (health <= 0){
                Destroy(gameObject);
            }
            Destroy(objectEnemy);
        }
    }

    public void Shoot()
    {
        GameObject bulletClon = Instantiate(Enemy_bullet_original);
        bulletClon.transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
    }
}
