using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMeScript : MonoBehaviour
{
    public GameObject enemy;

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Destroy(enemy);
        }
    }
}
