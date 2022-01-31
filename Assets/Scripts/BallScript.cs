using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody myRigidbody;
    Vector3 oldVel;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        oldVel = myRigidbody.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Vector3 playercurvel = collision.gameObject.GetComponent<PlayerMove>().myRigidbody.velocity;
            //Check what direction player is moving if any
            if (collision.gameObject.GetComponent<PlayerMove>().moveDirection == PlayerMove.direction.Left)
            {
                oldVel.x += 3;
                myRigidbody.velocity = -oldVel * 1.2f;

                Debug.Log("Sending ball Left");

            }
            else if(collision.gameObject.GetComponent<PlayerMove>().moveDirection == PlayerMove.direction.Right)
            {
                oldVel.x -= 3;
                myRigidbody.velocity = -oldVel * 1.2f;
                Debug.Log("Sending ball right");
            }
            else
            {
                myRigidbody.velocity = -oldVel * 1.2f;
                Debug.Log("Sending ball strait");
            }


        }else if (collision.gameObject.name == "RightWall" || collision.gameObject.name == "LeftWall")
        {
            myRigidbody.velocity = oldVel * 1.05f;
        }
    }

}
