using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MemoryGame : MonoBehaviour
{
    
    public Boolean nextLevel = false;
    public Player player;
    private PlayerInfo playerInfo;
    [Header("Set Dynamically")]
    public GameObject arialView;
    public GameObject FPS;
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject green;
    public GameObject yellowPart;
    public GameObject greenPart;
    public GameObject bluePart;
    public GameObject redPart;
    public float delay = 1f;
    public string pattern = "";
    // Start is called before the first frame update
    void Start()
    {
        playerInfo = FindObjectOfType<PlayerInfo>();
        //get random int between 1-4 inclusive
        int randomInt = UnityEngine.Random.Range(1, 5);
        pattern=pattern+randomInt.ToString();
        Debug.Log("Initial pattern"+pattern);
        DisplayPattern(pattern);
    }
    
    void DisplayPattern(string pattern)
    {
        int PatternLength = pattern.Length;
        Debug.Log("Pattern Length:" + PatternLength);
        //shows pattern from sky
        StartCoroutine(DelayedLoop());
        playerInfo.setPattern();
        //
        Invoke(nameof(camSwitch), delay*PatternLength);
        

        // Update is called once per frame
    }
    IEnumerator DelayedLoop()
    {
        //shows pattern from sky
        int PatternLength = pattern.Length;
        string tempPattern = pattern;
        arialView.SetActive(true);
        FPS.SetActive(false);
        for (int i = 0; i < PatternLength; i++)
        {
            string temp = tempPattern.Substring(0, 1);
            tempPattern = tempPattern.Substring(1);
            if (temp.Equals("1"))
            {
                red.SetActive(true);
                redPart.SetActive(true);
                

                // Wait for 1 second

                Invoke(nameof(DeactivateRed), delay);
                
                // Deactivate the object

            }
            else if (temp.Equals("2"))
            {
                yellow.SetActive(true);
                yellowPart.SetActive(true);
               

                // Wait for 1 second
                Invoke(nameof(DeactivateYellow), delay);
            }
            else if (temp.Equals("3"))
            {
                blue.SetActive(true);
                bluePart.SetActive(true);
                

                // Wait for 1 second
                Invoke(nameof(DeactivateBlue), delay);
            }
            else
            {
                green.SetActive(true);
                greenPart.SetActive(true);
                

                // Wait for 1 second
                Invoke(nameof(DeactivateGreen), delay);
            }
            yield return new WaitForSeconds(1.5f);

        }

    }
        void camSwitch()
    {
        arialView.SetActive(false);
        FPS.SetActive(true);
    }
    void DeactivateRed()
    {
        red.SetActive(false);
        redPart.SetActive(false);
        
    }
    void DeactivateYellow()
    {
        yellow.SetActive(false);
        yellowPart.SetActive(false);
       
    }
    void DeactivateBlue()
    {
        blue.SetActive(false);
        bluePart.SetActive(false);
        
    }
    void DeactivateGreen()
    {
        green.SetActive(false);
        greenPart.SetActive(false);
        
    }
    void Update()
    {
        if(nextLevel==true)
        {
            
            nextLevel=false;
            moveFPS();
            int randomInt = UnityEngine.Random.Range(1, 5);
            pattern = pattern + randomInt.ToString();
            Debug.Log("the pattern is "+pattern);
            DisplayPattern(pattern);

        }
    }
    public void moveFPS()
    {
        FPS.transform.position = new Vector3(0f, 0.5f, 0f);
    }
}
