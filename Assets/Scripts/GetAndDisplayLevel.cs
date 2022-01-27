using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetAndDisplayLevel : MonoBehaviour
{
    public GameObject bootstrap;
    public TextMeshProUGUI levelText;

    private void Start()
    {
        bootstrap = GameObject.Find("BootStraps");
        levelText.text = "Level "+bootstrap.GetComponent<LoadAndSaveNoDestroy>().Level+1;
    }
    public void DisplayLevel()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
