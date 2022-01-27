using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    public GameObject bootStrapper;

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
            SceneManager.LoadScene("Success", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log(collision.gameObject.name);
        }
    }



}
