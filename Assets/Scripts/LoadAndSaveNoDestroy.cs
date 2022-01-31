using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadAndSaveNoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int Level = 1;
    public int HighestLevelUnLocked = 1;
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadLevel(int _level)
    {
        if (_level == 1)
        {
            SceneManager.LoadScene("level1");
        }
        else if (_level == 2)
        {
            SceneManager.LoadScene("level2");
        }
        else if (_level == 3)
        {
            SceneManager.LoadScene("level3");
        }
    }
    public void IncrimentHighestLevelUnLocked(int levelJustPlayed)
    {
        //if level is unlocked

        if (levelJustPlayed >= HighestLevelUnLocked)
        {
            HighestLevelUnLocked++;
        }

    }


    public void LoadHomeLevel()
    {
        SceneManager.LoadScene("HomeMenu");
    }
}
