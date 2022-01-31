using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GetAndDisplayLevel : MonoBehaviour
{
    public GameObject bootstrap;
    public TextMeshProUGUI levelText;

    private void Start()
    {
        bootstrap = GameObject.Find("BootStraps");
        if (bootstrap == null)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            levelText.text = "Level " + bootstrap.GetComponent<LoadAndSaveNoDestroy>().Level;
        }
    }
    public void DisplayLevel()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
