using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{

    public GameObject car;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = car.transform.position;
        print("Script is running...");
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("r")) 
        {
            transform.position = startPosition;
        }
        print("Script is updated!");

    }
}
