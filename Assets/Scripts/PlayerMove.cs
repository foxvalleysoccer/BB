using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody myRigidbody;
    public Vector3 playerOldVel;
    public Vector3 lastPosition;
    public Vector3 localDirection;
    public enum direction { Right, Left, Strait };
    public direction moveDirection;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            playerOldVel = myRigidbody.velocity;
            // Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));
            transform.Translate(Vector3.MoveTowards(transform.position, new Vector3(target.x, transform.position.y, 0), moveSpeed * Time.deltaTime) - transform.position);
            // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //  transform.Translate(mousePos);


            var direction = transform.position - lastPosition;
            localDirection = transform.InverseTransformDirection(direction);
            if (localDirection.x < 0.1)
            {
                moveDirection = PlayerMove.direction.Left;
            }
            else if(localDirection.x>0.1)
            {
                moveDirection = PlayerMove.direction.Right;
            }
            else
            {
                moveDirection = PlayerMove.direction.Strait;
            }
            // Debug.Log("lastPosition" + lastPosition);
            // Debug.Log("transform.position" + transform.position);
          //  Debug.Log("localDirection.x = " + localDirection.x);
            //lastPosition = transform.position;


        }
        else
        {
            moveDirection = PlayerMove.direction.Strait;
           
        }
    }

}
