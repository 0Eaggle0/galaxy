using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject firstGroupOriginal;
    public GameObject ramGroupOriginal;
    private BaseAllEnemyGroop cur_enemyGroop;
    private int groupsCount = 0;
    private EnemyGroupType[] groupTypes = {EnemyGroupType.base_group, EnemyGroupType.ram_group};
    void Start()
    {
        Create_newGroup();
        groupsCount ++;
    }

    void Update()
    {
        if (cur_enemyGroop != null && cur_enemyGroop.isDestroyed == true){
            Destroy(cur_enemyGroop.gameObject);
            if (groupsCount == groupTypes.Length){
                SceneManager.LoadSceneAsync(SceneIds.win_scene_id);
            }
            else{
                Create_newGroup();  
                groupsCount ++;
            }
        }
    }

    void Create_newGroup()
    {
        if (groupTypes[groupsCount] == EnemyGroupType.base_group){
            GameObject new_Enemy_Group = Instantiate(firstGroupOriginal);
            new_Enemy_Group.transform.position = transform.position;
            cur_enemyGroop = new_Enemy_Group.GetComponent<FirstEnemyGroop>();
        } 
        else if (groupTypes[groupsCount] == EnemyGroupType.ram_group){
            GameObject new_Enemy_Group = Instantiate(ramGroupOriginal);
            new_Enemy_Group.transform.position = transform.position;
            cur_enemyGroop = new_Enemy_Group.GetComponent<RamEnemyGroup>();
        }
    }
}
