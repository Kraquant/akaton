using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectoires : MonoBehaviour
{
    public Material onMat;
    public Material offMat;
    public bool allume = false;
    // Start is called before the first frame update
    void Start()
    {
        allume = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (allume) { this.GetComponent<MeshRenderer>().material = onMat; }
        else { this.GetComponent<MeshRenderer>().material = offMat; }
    }
}
