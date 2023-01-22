using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamEnemyShip : MonoBehaviour
{
    public MovingDirection direction;
    private float speed = 0.2f;
    public SpriteRenderer shipRenderer;
    private float half_site = 0;
    private float health = 3;

    void Start()
    {
        half_site = shipRenderer.sprite.bounds.size.y / 2;
    }

    public void FixedUpdate()
    {
        switch (direction){
            case MovingDirection.right:
                Vector3 newPosition = new Vector3(transform.position.x + speed, transform.position.y, 0);
                Vector3 checkPosition = new Vector3(transform.position.x + speed + half_site, transform.position.y, 0);
                bool isOnScreen = ScreenUtils.isPosition_on_screen(checkPosition);
                if (isOnScreen){
                    transform.position = newPosition;
                }
                else{
                    if (transform.position.y > 0){
                        transform.rotation = Quaternion.Euler(0, 0, 180);
                        direction = MovingDirection.down;
                    }
                    else{
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                        direction = MovingDirection.up;
                    }
                }
                break;
            case MovingDirection.left:
                newPosition = new Vector3(transform.position.x - speed, transform.position.y, 0);
                checkPosition = new Vector3(transform.position.x - speed - half_site, transform.position.y, 0);
                isOnScreen = ScreenUtils.isPosition_on_screen(checkPosition);
                if (isOnScreen){
                    transform.position = newPosition;
                }
                else{
                    if (transform.position.y > 0){
                        transform.rotation = Quaternion.Euler(0, 0, 180);
                        direction = MovingDirection.down;
                    }
                    else{
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                        direction = MovingDirection.up;
                    }
                }
                break;
            case MovingDirection.up:
                newPosition = new Vector3(transform.position.x, transform.position.y + speed, 0);
                checkPosition = new Vector3(transform.position.x, transform.position.y + speed + half_site, 0);
                isOnScreen = ScreenUtils.isPosition_on_screen(checkPosition);
                if (isOnScreen){
                    transform.position = newPosition;
                }
                else{
                    if (transform.position.x > 0){
                        transform.rotation = Quaternion.Euler(0, 0, 90);
                        direction = MovingDirection.left;
                    }
                    else{
                        transform.rotation = Quaternion.Euler(0, 0, -90);
                        direction = MovingDirection.right;
                    }
                }
                break;
            case MovingDirection.down:
                newPosition = new Vector3(transform.position.x, transform.position.y - speed, 0);
                checkPosition = new Vector3(transform.position.x, transform.position.y - speed - half_site, 0);
                isOnScreen = ScreenUtils.isPosition_on_screen(checkPosition);
                if (isOnScreen){
                    transform.position = newPosition;
                }
                else{
                    if (transform.position.x > 0){
                        transform.rotation = Quaternion.Euler(0, 0, 90);
                        direction = MovingDirection.left;
                    }
                    else{
                        transform.rotation = Quaternion.Euler(0, 0, -90);
                        direction = MovingDirection.right;
                    }
                }
                break;
        }   
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
}
