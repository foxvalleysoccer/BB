using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace josh
{
    public class PlayerMove : MonoBehaviour
    {
        public float moveSpeed;
        public Rigidbody myRigidbody;
        public Vector3 playerOldVel;
        public Vector3 lastPosition;
        public Vector3 localDirection;
        public enum direction { Right, Left, Strait };
        public direction moveDirection;
        public GameObject ball;
        public Transform ballPos;
        void Start()
        {
            myRigidbody = GetComponent<Rigidbody>();
            ballPos = ball.transform;
        }



        // Update is called once per frame
        void Update()
        {
            TouchMove();
        }

        void TouchMove()
        {
            var myposition_Y = this.transform.position.y;
            var ball_Y = ballPos.position.y;
            var distanceBetween = ball_Y - myposition_Y;

            if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                playerOldVel = myRigidbody.velocity;
                Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));


                if (distanceBetween > 15)
                {
                    transform.Translate(Vector3.MoveTowards(transform.position, new Vector3(this.transform.position.x, transform.position.y + .5f, 0), moveSpeed * Time.deltaTime) - transform.position);
                }
                else
                {
                    transform.Translate(Vector3.MoveTowards(transform.position, new Vector3(target.x, transform.position.y, 0), moveSpeed * Time.deltaTime) - transform.position);
                }



                //this is to set the reboud direction of the ball
                var direction = transform.position - lastPosition;
                localDirection = transform.InverseTransformDirection(direction);
                if (localDirection.x < 0.1)
                {
                    moveDirection = PlayerMove.direction.Left;
                }
                else if (localDirection.x > 0.1)
                {
                    moveDirection = PlayerMove.direction.Right;
                }
                else
                {
                    moveDirection = PlayerMove.direction.Strait;
                }

            }
            else
            {
                if (distanceBetween > 15)
                {
                   // Debug.Log("Over 10 Moveng player");
                    transform.Translate(Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y + .5f, 0), moveSpeed * Time.deltaTime) - transform.position);
                }
                moveDirection = PlayerMove.direction.Strait;

            }


        }

    }
}