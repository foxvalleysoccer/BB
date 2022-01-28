using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScenes : MonoBehaviour
{
    public GameObject bootstrap;


    private void Start()
    {
        bootstrap = GameObject.Find("BootStraps");

    }
    public void LoadLevel()
    {
        var level = bootstrap.GetComponent<LoadAndSaveNoDestroy>().Level;
        bootstrap.GetComponent<LoadAndSaveNoDestroy>().LoadLevel(level);

    }
    public void loadHomeScene()
    {
        bootstrap.GetComponent<LoadAndSaveNoDestroy>().LoadHomeLevel();
    }

}
