using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OxygenControll : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentTime = 0.0f;
    public float startingTime = 10.0f;
    private bool isDead = false;
    private XRSocketInteractor socket;
    void Start()
    {
        currentTime = startingTime;
        socket = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            isDead = true;
        }
        
    }

    public void OnOxygenEnter(SelectEnterEventArgs args)
    {
        IXRSelectInteractable bouteille = args.interactableObject;
        GameObject bouteilleGO = bouteille.transform.gameObject;
        Bottle bouteilleScript = bouteilleGO.GetComponent<Bottle>();
        if (bouteilleScript.getStatus()) //if the bottle is not empty
        {
            bouteilleScript.emptyBottle();
            currentTime = startingTime;

        }
        
    }

    public float getTimer()
    {
        return currentTime;
    }
    public bool getHealth()
    {
        return isDead;
    }
}
