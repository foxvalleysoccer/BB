using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAndPlayerCollision : MonoBehaviour
{
    public GameObject player;

    public void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        //  Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            player.GetComponent<PlayerManager>().PlayerHit(this.gameObject.name);
        }

        var position = player.transform.position;
        if (gameObject.name == "RightWall")
        {
            position.x -= 1;
        }
        else if (gameObject.name == "LeftWall")
        {
            position.x += 1;
        }

        player.transform.position = position;
        Debug.Log("Hit Wall Moved Player");
        //    if (collision.gameObject.name =="5")
        //{
        //    player.GetComponent<PlayerManager>().PlayerHit();
        //}
        //else if (collision.gameObject.name == "4")
        //{
        //    player.GetComponent<PlayerManager>().PlayerHit();
        //}
        //else if (collision.gameObject.name == "3")
        //{
        //    player.GetComponent<PlayerManager>().PlayerHit();
        //}
        //else if (collision.gameObject.name == "2")
        //{
        //    player.GetComponent<PlayerManager>().PlayerHit();
        //}
        //else if (collision.gameObject.name == "1")
        //{
        //    player.GetComponent<PlayerManager>().PlayerHit();
        //}
    }



}
