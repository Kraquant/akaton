using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManivelleGesture : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightManagerObject;
    private LightManager manager;

    private float currentStack;
    public float maxStack = 5.0f;
    public float factor = 3.0f;

    private bool awake;
    void Start()
    {
        currentStack = 0;
        manager = lightManagerObject.GetComponent<LightManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!awake)
        {
            return;
        }
        currentStack += 1 * Time.deltaTime;
        if (currentStack >= maxStack)
        {
            currentStack = maxStack;
        }
    }

    public void grabbing()
    {
        awake = true;
        currentStack = 0;
    }

    public void releasing()
    {
        awake = false;
        manager.receivePower(currentStack * factor);
        

    }
}
