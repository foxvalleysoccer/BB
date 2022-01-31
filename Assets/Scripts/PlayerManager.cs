using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject bootStrapper;

    public GameObject player_CenterBrick;
    public GameObject player_RightCenterBrick;
    public GameObject player_LeftCenterBrick;
    public GameObject player_RightOuterBrick;
    public GameObject player_LeftOuterBrick;
    public bool colidedAlready = false;
    public void Start()
    {
        player_CenterBrick = GameObject.Find("1");
        player_RightCenterBrick = GameObject.Find("2");
        player_LeftCenterBrick = GameObject.Find("3");
        player_RightOuterBrick = GameObject.Find("4");
        player_LeftOuterBrick = GameObject.Find("5");

        bootStrapper = GameObject.Find("BootStraps");
        if (bootStrapper == null)
        {
            Debug.Log("FIS THIS NOW");
        }
        else
        {
            SetPlayerLength();
        }
    }
    public void PlayerHit(string wall)
    {
        if (colidedAlready == true)
        {
            return;
        }
        colidedAlready = true;
        //  Vector3 scalechange = new Vector3(-.25f,0,0);
        //  this.transform.localScale -= scalechange;
        bootStrapper.GetComponent<PlayerLengthManager>().playerLength -= 1;

       StartCoroutine(SetPlayerLength());
    }
     IEnumerator SetPlayerLength()
    {
        if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength == 5)
        {
            player_CenterBrick.SetActive(true);
            player_RightOuterBrick.SetActive(true);
            player_LeftOuterBrick.SetActive(true);
            player_LeftCenterBrick.SetActive(true);
            player_RightCenterBrick.SetActive(true);
        }
        else if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength == 4)
        {
            player_RightOuterBrick.SetActive(false);
        }
        else if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength == 3)
        {
            player_RightOuterBrick.SetActive(false);
            player_LeftOuterBrick.SetActive(false);
        }
        else if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength == 2)
        {
            player_RightOuterBrick.SetActive(false);
            player_LeftOuterBrick.SetActive(false);
            player_LeftCenterBrick.SetActive(false);
        }
        else if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength == 1)
        {
            player_RightOuterBrick.SetActive(false);
            player_LeftOuterBrick.SetActive(false);
            player_LeftCenterBrick.SetActive(false);
            player_RightCenterBrick.SetActive(false);
        }else if (bootStrapper.GetComponent<PlayerLengthManager>().playerLength <= 0)
        {

            Debug.Log("Game Over");
        }


        yield return new WaitForSeconds(3);
        colidedAlready = false;
    }

}
