using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [Header("Set Dynamically")]
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject green;
    public GameObject yellowPart;
    public GameObject greenPart;
    public GameObject bluePart;
    public GameObject redPart;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Red Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            red.gameObject.SetActive(true);
            redPart.gameObject.SetActive(true);

        }
        else if (other.gameObject.CompareTag("Green Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            green.gameObject.SetActive(true);
            greenPart.gameObject.SetActive(true);

        }
        else if (other.gameObject.CompareTag("Yellow Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            yellow.gameObject.SetActive(true);
            yellowPart.gameObject.SetActive(true);

        }
        else if (other.gameObject.CompareTag("Blue Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            blue.gameObject.SetActive(true);
            bluePart.gameObject.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Red Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            red.gameObject.SetActive(false);
            redPart.gameObject.SetActive(false);

        }
        else if (other.gameObject.CompareTag("Green Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            green.gameObject.SetActive(false);
            greenPart.gameObject.SetActive(false);

        }
        else if (other.gameObject.CompareTag("Yellow Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            yellow.gameObject.SetActive(false);
            yellowPart.gameObject.SetActive(false);

        }
        else if (other.gameObject.CompareTag("Blue Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            blue.gameObject.SetActive(false);
            bluePart.gameObject.SetActive(false);

        }
    }
}
