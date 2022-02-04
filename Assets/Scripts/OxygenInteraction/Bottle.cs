using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isFull;

    public Material matEmpty;

    public GameObject cylinder;

    void Start()
    {
        isFull = true;
    }

    // Update is called once per frame
    void Update()
    {   
    }

    public void emptyBottle()
    {
        isFull = false;
        cylinder.GetComponent<MeshRenderer>().material = matEmpty;

    }

    public bool getStatus()
    {
        return isFull;
    }
}
