using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isFull;
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

    }

    public bool getStatus()
    {
        return isFull;
    }
}
