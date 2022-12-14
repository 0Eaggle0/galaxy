using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WInScreenManager : MonoBehaviour
{
    public void Close_game()
    {
        Application.Quit();
    }

    public void Restart_level()
    {
        SceneManager.LoadScene(SceneIds.level_scene_id);
    }

    public void Return_to_map(){
        SceneManager.LoadSceneAsync(SceneIds.map_scene_id);
    } 
}
