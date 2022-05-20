using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControler : MonoBehaviour
{
    public Vector3 movementVector;

    public float xSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 8)
        {
            //transform.position += movementVector;
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        
    }
}
