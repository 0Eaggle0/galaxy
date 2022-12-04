using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemyGroop : BaseAllEnemyGroop
{
    public BrownEnemy ship_0;
    public BrownEnemy ship_1;
    public BrownEnemy ship_2;
    public BrownEnemy ship_3;
    public BrownEnemy ship_4;
    public BrownEnemy ship_5;

    private float speed = 0.14f; 
    private int direction = -1;
    private List<BrownEnemy> ships = new List<BrownEnemy>();
    private System.Random generator = new System.Random();

    void Start()
    {
        ships.Add(ship_0);
        ships.Add(ship_1);
        ships.Add(ship_2);
        ships.Add(ship_3);
        ships.Add(ship_4);
        ships.Add(ship_5);
        InvokeRepeating("GroupShoot", 0.0f, 1f);
    }

    void Update()
    {
        ships.RemoveAll(elem => elem == null);

        if (ship_0 == null
         && ship_1 == null 
         && ship_2 == null 
         && ship_3 == null 
         && ship_4 == null 
         && ship_5 == null){
            isDestroyed = true;
            CancelInvoke("GroupShoot");
        }

        if (direction == -1){
            float min = Get_left_edge();
            min += speed * direction;
            if (min <= -12){
                direction *= -1;
            }
            else{
                transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
            }
        }
        else{
            float max = Get_right_edge();
            max += speed * direction;
            if (max >= 12){
                direction *= -1;
            }
            else{
                transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0);
            }
        }
    }

    float Get_left_edge()
    {
        float mini = float.MaxValue;
        for (int i = 0; i < ships.Count; i++){
            if (ships[i].transform.position.x < mini){
                mini = ships[i].transform.position.x;
            }
        }
        return mini;
    }
    float Get_right_edge()
    {
        float maxi = float.MinValue;
        for (int i = 0; i < ships.Count; i++){
            if (ships[i].transform.position.x > maxi){
                maxi = ships[i].transform.position.x;
            }
        }
        return maxi;
    }

    void GroupShoot()
    {
        int random_index = generator.Next(0, ships.Count - 1);
        ships[random_index].Shoot();
    }
}
