using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public List<GameObject> lights;

    private float currentPower;
    public float maxCapacity;

    private bool lightsOn;
    private float tempPower;

    // Start is called before the first frame update
    void Start()
    {
        tempPower = 0;
        currentPower = maxCapacity;
        lightsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentPower -= 1 * Time.deltaTime;
        if (currentPower <= 0)
        {
            currentPower = 0;
            if (lightsOn)
            {
                lightsOn = false;
                shutOffLights();
            }

        }
    }

    public void leverTriggered()
    {
        float newPower = currentPower + tempPower;
        if (newPower < maxCapacity)
        {
            newPower = maxCapacity;
        }
        currentPower = newPower;
        if (currentPower > 0 && !lightsOn)
        {
            turnOnLights();
        }
    }

    public void leverReleased()
    {

    }

    public void receivePower(float power)
    {
        tempPower += power;
    }

    public float getPower()
    {
        return currentPower;
    }

    private void shutOffLights()
    {

    }

    private void turnOnLights()
    {

    }
}
