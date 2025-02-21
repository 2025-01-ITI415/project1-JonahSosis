using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MemoryGame memoryGame;
    private Rigidbody rb;
    public string pattern;
    public string playerPattern="";
    public string nextInOrder = "";
    [Header("Set Dynamically")]
    public GameObject gameOver;
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
        memoryGame=FindObjectOfType<MemoryGame>();
        pattern = memoryGame.pattern;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //start by finding he number they need to find
        //compare the one they went into to that. 

        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        
        nextInOrder = pattern.Substring(0, 1);
        if (other.gameObject.CompareTag("Red Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            playerPattern = playerPattern + "1";
            if(nextInOrder.Equals("1"))
            {
                red.gameObject.SetActive(true);
                redPart.gameObject.SetActive(true);
            }
            else
            {
                gameOver.SetActive(true);
            }
            

        }
        else if (other.gameObject.CompareTag("Green Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            playerPattern = playerPattern + "4";
            if (nextInOrder.Equals("4"))
            {
                green.gameObject.SetActive(true);
                greenPart.gameObject.SetActive(true);
            }
            else
            {
                gameOver.SetActive(true);
            }
            
           

        }
        else if (other.gameObject.CompareTag("Yellow Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            playerPattern = playerPattern + "2";
            if (nextInOrder.Equals("2"))
            {
                yellow.gameObject.SetActive(true);
                yellowPart.gameObject.SetActive(true);
            }
            else
            {
                gameOver.SetActive(true);
            }
            

        }
        else if (other.gameObject.CompareTag("Blue Pillar"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            playerPattern = playerPattern + "3";
            if (nextInOrder == "3")
            {
                blue.gameObject.SetActive(true);
                bluePart.gameObject.SetActive(true);
            }
            else
            {
                gameOver.SetActive(true);
            }

        }
        pattern = pattern.Substring(1);//revisit this, its an error
        if (playerPattern.Equals(memoryGame.pattern))
        {
            //next level
        }
        else
        {
            //next round
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
