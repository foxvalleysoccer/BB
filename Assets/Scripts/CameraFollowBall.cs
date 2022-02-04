using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollowBall : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    public float oldYPosition;
    public GameObject player;
    void Update()
    {
        if (oldYPosition < ball.position.y)
        {
            var scenename = SceneManager.GetActiveScene().name;
            if (scenename == "Level2")
            {
                transform.position = new Vector3(player.transform.position.x, ball.position.y, -23.36f); // Camera follows the player with specified offset position

            }
            else
            {
                transform.position = new Vector3(0.53f, ball.position.y, -23.36f); // Camera follows the player with specified offset position

            }
            Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height - Screen.height, 0));
            //  Debug.Log(stageDimensions.y);
            //player.transform.position = new Vector3(player.transform.position.x, stageDimensions.y + 2.0f, player.transform.position.z);
            oldYPosition = ball.position.y;
        }
    }
}
