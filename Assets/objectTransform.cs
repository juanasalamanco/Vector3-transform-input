using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransform : MonoBehaviour
{
    public GameObject myCube;
    public Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {
        myCube.transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
