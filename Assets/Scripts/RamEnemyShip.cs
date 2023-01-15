using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamEnemyShip : MonoBehaviour
{
    public MovingDirection direction;
    private float speed = 0.2f;

    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        switch (direction){
            case MovingDirection.right:
                Vector3 newPosition = new Vector3(transform.position.x + speed, transform.position.y, 0);
                bool isOnScreen = ScreenUtils.isPosition_on_screen(newPosition);
                if (isOnScreen){
                    transform.position = newPosition;
                }
                else{
                    direction = MovingDirection.down;
                }
                break;
            case MovingDirection.left:
                //left
                break;
            case MovingDirection.up:
                //up
                break;
            case MovingDirection.down:
                //down
                break;
        }   
    }
}
