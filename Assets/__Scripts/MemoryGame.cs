using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MemoryGame : MonoBehaviour
{
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
        //get random int between 1-4 inclusive
        int randomInt = Random.Range(1, 5);
        pattern=pattern+randomInt.ToString();
        DisplayPattern(pattern);
    }
    
    void DisplayPattern(string pattern)
    {
        int PatternLength = pattern.Length;
        string tempPattern = pattern;
        arialView.SetActive(true);
        FPS.SetActive(false);
        for (int i = 0; i < PatternLength; i++)
        {
            string temp = tempPattern.Substring(0, 1);
            tempPattern = tempPattern.Substring(1);
            if(temp.Equals("1"))
            {
                red.SetActive(true);
                redPart.SetActive(true);
                Debug.Log("Object Activated");

                // Wait for 1 second

                Invoke(nameof(DeactivateRed), delay);

                // Deactivate the object
                
            }
            else if(temp.Equals("2"))
            {
                yellow.SetActive(true);
                yellowPart.SetActive(true);
                Debug.Log("Object Activated");

                // Wait for 1 second
                Invoke(nameof(DeactivateYellow), delay);
            }
            else if (temp.Equals("3"))
            {
                blue.SetActive(true);
                bluePart.SetActive(true);
                Debug.Log("Object Activated");

                // Wait for 1 second
                Invoke(nameof(DeactivateBlue), delay);
            }
            else
            {
                green.SetActive(true);
                greenPart.SetActive(true);
                Debug.Log("Object Activated");

                // Wait for 1 second
                Invoke(nameof(DeactivateGreen), delay);
            }
            

        }
        Invoke(nameof(camSwitch), delay*PatternLength);
        

        // Update is called once per frame
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
        Debug.Log("Red Object Deactivated");
    }
    void DeactivateYellow()
    {
        yellow.SetActive(false);
        yellowPart.SetActive(false);
        Debug.Log("Yellow Object Deactivated");
    }
    void DeactivateBlue()
    {
        blue.SetActive(false);
        bluePart.SetActive(false);
        Debug.Log("Yellow Object Deactivated");
    }
    void DeactivateGreen()
    {
        green.SetActive(false);
        greenPart.SetActive(false);
        Debug.Log("Yellow Object Deactivated");
    }
    void Update()
    {
        
    }
}
