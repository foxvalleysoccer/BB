using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    

    public void PlayerHit()
    {
       Vector3 scalechange = new Vector3(-.25f,0,0);
        this.transform.localScale -= scalechange;

    }


}
