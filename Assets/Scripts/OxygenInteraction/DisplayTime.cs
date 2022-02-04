using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text countdownText;
    public GameObject bottleManager;
    private OxygenControll oxygenScript;
    void Start()
    {
        oxygenScript = bottleManager.GetComponent<OxygenControll>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = oxygenScript.getTimer().ToString("0");
    }
}
