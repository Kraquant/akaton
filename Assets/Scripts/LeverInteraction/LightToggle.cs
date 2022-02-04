using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public Material onMat;
    public Material offMat;

    public GameObject neon1;
    public GameObject neon2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOn()
    {
        neon1.GetComponent<MeshRenderer>().material = onMat;
        neon2.GetComponent<MeshRenderer>().material = onMat;
    }

    public void turnOff()
    {
        neon1.GetComponent<MeshRenderer>().material = offMat;
        neon2.GetComponent<MeshRenderer>().material = offMat;

    }
}
