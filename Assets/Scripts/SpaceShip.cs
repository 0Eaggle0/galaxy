using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public GameObject clon_bullet;
    public SpriteRenderer sprite_renderer;

    float speed = 0.15f;
    void Start()
    {
        
    }

    void Update()
    {
        float half_width = sprite_renderer.bounds.size.x / 2;
        float half_height = sprite_renderer.bounds.size.y / 2;

        bool  isKeyLeft  = Input.GetKey(KeyCode.A);
        if (isKeyLeft == true){
            Vector3 new_position = new Vector3(transform.position.x - speed, transform.position.y, 0);
            Vector3 check_position = new Vector3(new_position.x - half_width, new_position.y, 0);
            if (ScreenUtils.isPosition_on_screen(check_position) == true){
                transform.position = new_position;
            }
        }

        bool  isKeyUp  = Input.GetKey(KeyCode.W);
        if (isKeyUp == true){
            Vector3 new_position = new Vector3(transform.position.x, transform.position.y + speed, 0);
            Vector3 check_position = new Vector3(new_position.x, new_position.y + half_height, 0);
            if (ScreenUtils.isPosition_on_screen(check_position) == true){
                transform.position = new_position;
            }
        }

        bool  isKeyRight  = Input.GetKey(KeyCode.D);
        if (isKeyRight == true){
            Vector3 new_position = new Vector3(transform.position.x + speed, transform.position.y, 0);
            Vector3 check_position = new Vector3(new_position.x + half_width, new_position.y, 0);
            if (ScreenUtils.isPosition_on_screen(check_position) == true){
                transform.position = new_position;
            }
        }

        bool  isKeyDown  = Input.GetKey(KeyCode.S);
        if (isKeyDown == true){
            Vector3 new_position = new Vector3(transform.position.x, transform.position.y - speed, 0);
            Vector3 check_position = new Vector3(new_position.x, new_position.y - half_height, 0);
            if (ScreenUtils.isPosition_on_screen(check_position) == true){
                transform.position = new_position;
            }
        }

        bool  isKeyShoot  = Input.GetKeyDown(KeyCode.Space);
        if (isKeyShoot == true){
            GameObject bulletClon = Instantiate(clon_bullet);
            bulletClon.transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
        }
    }
}
