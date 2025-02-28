using System;
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
    public Boolean triggerExit=true;
    [Header("Set Dynamically")]
    public GameObject FPS;
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
        
        nextInOrder = memoryGame.pattern.Substring(0, 1);//This is wrong and is causing errors
        if (triggerExit == true)
        {
            triggerExit = false;

            if (other.gameObject.CompareTag("Red Pillar"))
            {
                // Make the other game object (the pick up) inactive, to make it disappear
                
                playerPattern = playerPattern + "1";//jk this is wrong
                if (nextInOrder.Equals("1"))
                {
                    red.gameObject.SetActive(true);
                    redPart.gameObject.SetActive(true);
                    Debug.Log("red activate");
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
                    Debug.Log("green activate");
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
                    Debug.Log("yellow activate");
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
                    Debug.Log("blue activate");
                }
                else
                {
                    gameOver.SetActive(true);
                }

            }

            if (playerPattern.Equals(memoryGame.pattern))
            {
                Debug.Log("End of level pattern" +playerPattern);
                red.gameObject.SetActive(false);
                redPart.gameObject.SetActive(false);
                green.gameObject.SetActive(false);
                greenPart.gameObject.SetActive(false);
                yellow.gameObject.SetActive(false);
                yellowPart.gameObject.SetActive(false);
                blue.gameObject.SetActive(false);
                bluePart.gameObject.SetActive(false);
                playerPattern = "";
                memoryGame.nextLevel = true;
                Debug.Log("Next Level");
            }
            else
            {
                
                pattern = pattern.Substring(1);
                playerPattern = "";
                Debug.Log("Correct, next round");
                //start next round
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        triggerExit = true;
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
