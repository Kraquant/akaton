using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightTimer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text countdownText;
    public GameObject lightManager;
    private LightManager lightmanagerScript;
    void Start()
    {
        lightmanagerScript = lightManager.GetComponent<LightManager>();

    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = lightmanagerScript.getPower().ToString("0");
    }
}
