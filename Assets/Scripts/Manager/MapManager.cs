using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void Start_level1()
    {
        SceneManager.LoadSceneAsync(SceneIds.level_scene_id);
    }
}
