using UnityEngine;
using UnityEngine.Events;

public class Boutons : MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent : UnityEvent { }

    public float pressLength;
    public bool pressed;
    public ButtonEvent downEvent;
    public bool allume;

    Vector3 startPos;
    Rigidbody rb;

    public Material allumeMat;
    public Material eteintMat;
    
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        this.GetComponent<MeshRenderer>().material = eteintMat;
    }

    void Update()
    {
        if (allume) //&& electricity);
        {
            this.GetComponent<MeshRenderer>().material = allumeMat;
        } else
        {
            this.GetComponent<MeshRenderer>().material = eteintMat;
        }
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        float distance = Mathf.Abs(transform.position.y - startPos.y);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.position = new Vector3(transform.position.x, startPos.y - pressLength, transform.position.z);
            if (!pressed)
            {
                pressed = true;
                // If we have an event, invoke it
                downEvent?.Invoke();
            }
        }
        else
        {
            // If we aren't all the way down, reset our press
            pressed = false;
        }
        // Prevent button from springing back up past its original position
        if (transform.position.y > startPos.y)
        {
            transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
        }
    }
}