using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left movement//
        if (Input.GetKeyDown(KeyCode.A)) {
            transform.Position  += new Vector3.left;
        }
           //right movement//
        if (Input.GetKeyDown(KeyCode.D)) {
            transform.Position  += new Vector3.right;
        }
             
             //up movement//
         if (Input.GetKeyDown(KeyCode.W)) {
            transform.Position  += new Vector3.forward;
        }


    }
}
