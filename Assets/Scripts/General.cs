using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class General : MonoBehaviour
{
    public GameObject elec;
    private LightManager eleControl;
    private float oxygenLvl, elecLvl;
    // Start is called before the first frame update
    void Start()
    {
        oxygenLvl = GameObject.Find("Station").transform.Find("Controller").GetComponent<OxygenControll>().startingTime;
        GameObject.Find("Oxygene").GetComponent<Slider>().value = oxygenLvl;

        eleControl = elec.GetComponent<LightManager>();
        elecLvl = eleControl.maxCapacity;
        GameObject.Find("Electricite").GetComponent<Slider>().value = elecLvl;
    }

    // Update is called once per frame
    void Update()
    {
        oxygenLvl = GameObject.Find("Station").transform.Find("Controller").GetComponent<OxygenControll>().getTimer();
        GameObject.Find("Oxygene").GetComponent<Slider>().value = oxygenLvl;

        elecLvl = eleControl.getPower();
        GameObject.Find("Electricite").GetComponent<Slider>().value = elecLvl;
    }
}
