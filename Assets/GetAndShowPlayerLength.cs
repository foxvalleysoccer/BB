using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAndShowPlayerLength : MonoBehaviour
{
    public GameObject bootstrap;
    public GameObject[] gamepieces;

    private void Start()
    {
        bootstrap = GameObject.Find("BootStraps");
        DisplayGamePieces();
    }
    // Update is called once per frame
    public void DisplayGamePieces()
    {
        var playerLength = bootstrap.GetComponent<PlayerLengthManager>().playerLength;
        foreach (GameObject piece in gamepieces)
        {
            piece.SetActive(false);
        }

        for (var i = 0; i < playerLength; i++)
        {
            gamepieces[i].SetActive(true);
        }
    }
}
