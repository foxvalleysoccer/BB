using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    public GameObject bootStrapper;
    public int _myLevel;
    public void Start()
    {
        bootStrapper = GameObject.Find("BootStraps");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Circle")
        {
            Debug.Log("added to level ++");
            bootStrapper.GetComponent<LoadAndSaveNoDestroy>().Level++;
            bootStrapper.GetComponent<LoadAndSaveNoDestroy>().IncrimentHighestLevelUnLocked(_myLevel);

           SceneManager.LoadScene("Success", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log(collision.gameObject.name);
        }
    }



}
