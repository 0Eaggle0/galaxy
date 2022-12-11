using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject firstGroupOriginal;
    private FirstEnemyGroop cur_enemyGroop;
    private int Groupscount = 0;
    void Start()
    {
        Create_newGroup();
        Groupscount ++;
    }

    void Update()
    {
        if (cur_enemyGroop != null && cur_enemyGroop.isDestroyed == true){
            Destroy(cur_enemyGroop.gameObject);
            if (Groupscount == 5){
                SceneManager.LoadSceneAsync(SceneIds.win_scene_id);
            }
            else{
                Create_newGroup();  
                Groupscount ++;
            }
        }
    }

    void Create_newGroup()
    {
        GameObject new_Enemy_Group = Instantiate(firstGroupOriginal);
        new_Enemy_Group.transform.position = transform.position;
        cur_enemyGroop = new_Enemy_Group.GetComponent<FirstEnemyGroop>();
    }
}
