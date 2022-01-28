using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageDetails : MonoBehaviour
{
    public GameObject bootstrap;
    public Image parentImage;
    public Image lockedIcon;
    public TextMeshProUGUI Level;
    public Image Star1;
    public Image Star2;
    public Image Star3;
    public int levelNumber;
    public bool isLocked = true;
    // Start is called before the first frame update
    void Start()
    {
        bootstrap = GameObject.Find("BootStraps");
      
        if (isLocked)
        {
            lockedIcon.enabled = true;
        }
        else
        {
            lockedIcon.enabled = false;
        }

        Star1.enabled = false;
        Star2.enabled = false;
        Star3.enabled = false;
        Level.text = levelNumber.ToString();
        DisplayIcon();
    }
    public void LoadLevel()
    {
        if (isLocked == false)
        {
            bootstrap.GetComponent<LoadAndSaveNoDestroy>().LoadLevel(levelNumber);
        }
    }

    public void DisplayIcon()
    {
        int highestUnlocked = bootstrap.GetComponent<LoadAndSaveNoDestroy>().HighestLevelUnLocked;

        if (highestUnlocked<levelNumber)
        {
            lockedIcon.enabled = true;
            Star1.enabled = false;
            Star2.enabled = false;
            Star3.enabled = false;
        }
        else
        {
            lockedIcon.enabled = false;
            Star1.enabled = true;
            Star2.enabled = true;
            Star3.enabled = true;
            isLocked = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
