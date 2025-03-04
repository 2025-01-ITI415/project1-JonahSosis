using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    // Start is called before the first frame update
    private MemoryGame memoryGame;
    public string nextInOrder = "";
    public string playerPattern="";
    string pattern = "";
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
    void Start()
    {
        memoryGame = FindObjectOfType<MemoryGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setPattern()
    {
        pattern = memoryGame.pattern;
    }
    public void addPlayerPattern(string patternAddition)
    {
        
        nextInOrder =pattern.Substring(0, 1);
        playerPattern = playerPattern + patternAddition;
        Debug.Log("Pattern at test point"+pattern);
        Debug.Log(pattern.Substring(0, 1));
        Debug.Log("Next in order is:" + nextInOrder+" and you selected:"+patternAddition);
        checkAnswer();
        patternCompare();
    }
    void patternCompare()
    {
        if (playerPattern.Equals(memoryGame.pattern))
        {
            Debug.Log("End of level pattern" + playerPattern);
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
            Debug.Log("Correct, next round");
            Debug.Log("Player Pattern:" + playerPattern + " Pattern:" + memoryGame.pattern);
            pattern = pattern.Substring(1);
            //playerPattern = "";
            
            //start next round
        }
    }
    public void playerPatternClear()
    {
        playerPattern = "";
    }
    IEnumerator DisableObjectsAfterDelay()
    {
        yield return new WaitForSeconds(0.75f); // Wait for 0.75 seconds

        green.SetActive(false);
        greenPart.SetActive(false);
        red.gameObject.SetActive(false);
        redPart.gameObject.SetActive(false);
        yellow.gameObject.SetActive(false);
        yellowPart.gameObject.SetActive(false);
        blue.gameObject.SetActive(false);
        bluePart.gameObject.SetActive(false);
    }
    void checkAnswer()
    {
        Debug.Log("At checkAnswer, next in order:"+nextInOrder+", Player Pattern:"+ playerPattern.Substring(playerPattern.Length - 1, 1)[0]);
        Debug.Log("next in order vs player pick" + nextInOrder.Equals(playerPattern.Substring(playerPattern.Length - 1, 1)));
        Debug.Log("next in order equals 1" + nextInOrder.Equals("1"));
        Debug.Log("next in order equals 2" + nextInOrder.Equals("2"));
        Debug.Log("next in order equals 3" + nextInOrder.Equals("3"));
        Debug.Log("next in order equals 4" + nextInOrder.Equals("4"));
        if (nextInOrder.Equals(playerPattern.Substring(playerPattern.Length - 1, 1)) && nextInOrder.Equals("1"))
        {
            red.gameObject.SetActive(true);
            redPart.gameObject.SetActive(true);
            Debug.Log("red activate");
            StartCoroutine(DisableObjectsAfterDelay());
        }
        else if (nextInOrder.Equals(playerPattern.Substring(playerPattern.Length - 1, 1)) && nextInOrder.Equals("4"))
        {
            green.gameObject.SetActive(true);
            greenPart.gameObject.SetActive(true);
            Debug.Log("green activate");
            StartCoroutine(DisableObjectsAfterDelay());
        }
        else if (nextInOrder.Equals(playerPattern.Substring(playerPattern.Length - 1, 1)) && nextInOrder.Equals("2"))
        {
            yellow.gameObject.SetActive(true);
            yellowPart.gameObject.SetActive(true);
            Debug.Log("yellow activate");
            StartCoroutine(DisableObjectsAfterDelay());
        }
        else if (nextInOrder.Equals(playerPattern.Substring(playerPattern.Length - 1, 1)) && nextInOrder.Equals("3"))
        {
            blue.gameObject.SetActive(true);
            bluePart.gameObject.SetActive(true);
            Debug.Log("blue activate");
            StartCoroutine(DisableObjectsAfterDelay());
        }
        else
        { 
            gameOver.SetActive(true);
            Debug.Log("GameOver");
        }
    }
}
