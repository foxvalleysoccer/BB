using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectCollisionWtihBall : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Circle")
        {
            SceneManager.LoadScene("Failed", LoadSceneMode.Single);
        }
        else
        {
            // Debug.Log(collision.gameObject.name);
        }
    }


}
