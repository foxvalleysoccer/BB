using UnityEngine;
namespace josh
{

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
          //  Debug.Log(oldVel);
        }
        public Vector3 forcetoAdd;
        public bool addforce = false;
        private void FixedUpdate()
        {
            if (addforce)
            {
                if (dir == PlayerMove.direction.Left)
                {
                    Debug.Log("Sending ball Left");
                    myRigidbody.AddForce(new Vector3(-2, 1.1f, 0), ForceMode.Impulse);
                }else if (dir == PlayerMove.direction.Right)
                {
                    myRigidbody.AddForce(new Vector3(2, 1.1f, 0), ForceMode.Impulse);
                    Debug.Log("Sending ball right");
                }
                else
                {
                    myRigidbody.AddForce(new Vector3(0, 1.2f, 0), ForceMode.Impulse);
                    Debug.Log("Sending ball strait");
                }
               // myRigidbody.AddForce(new Vector3(0,oldVel.y,0), ForceMode.Impulse);
                Debug.Log("update Added Force");
                addforce = false;
            }
        }
        public PlayerMove.direction dir;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                Vector3 playercurvel = collision.gameObject.GetComponent<PlayerMove>().myRigidbody.velocity;
                //Check what direction player is moving if any
                if (collision.gameObject.GetComponent<PlayerMove>().moveDirection == PlayerMove.direction.Left)
                {
                  
                    dir = PlayerMove.direction.Left;
                   
                    addforce = true;
                }
                else if (collision.gameObject.GetComponent<PlayerMove>().moveDirection == PlayerMove.direction.Right)
                {
                    dir = PlayerMove.direction.Right;
              
                    
                    addforce = true;
                }
                else
                {

                    addforce = true;
            
                }


            }
            else if (collision.gameObject.name == "RightWall" || collision.gameObject.name == "LeftWall")
            {
                //myRigidbody.velocity = oldVel * 1.05f;
            }
        }

    }
}