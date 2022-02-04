using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class General : MonoBehaviour
{
    private float oxygenLvl, elecLvl;
    // Start is called before the first frame update
    void Start()
    {
        oxygenLvl = GameObject.Find("Station").transform.Find("Controller").GetComponent<OxygenControll>().startingTime;
        GameObject.Find("Oxygene").GetComponent<Slider>().value = oxygenLvl;
    }

    // Update is called once per frame
    void Update()
    {
        oxygenLvl = GameObject.Find("Station").transform.Find("Controller").GetComponent<OxygenControll>().getTimer();
        GameObject.Find("Oxygene").GetComponent<Slider>().value = oxygenLvl;
    }
}
