using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTemp : MonoBehaviour
{
    
    private PlayerInfo playerInfo;
    private MemoryGame memoryGame;
    private Rigidbody rb;
    [Header("Set Dynamically")]
    public GameObject FPS;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInfo = FindObjectOfType<PlayerInfo>();
        memoryGame = FindObjectOfType<MemoryGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red Pillar"))
        {
            playerInfo.addPlayerPattern("1");
            FPS.transform.position = new Vector3(0f, 0.5f, 0f);
        }
        else if (other.gameObject.CompareTag("Green Pillar"))
        {
            playerInfo.addPlayerPattern("4");
            FPS.transform.position = new Vector3(0f, 0.5f, 0f);
        }
        else if (other.gameObject.CompareTag("Blue Pillar"))
        {
            playerInfo.addPlayerPattern("3");
            FPS.transform.position = new Vector3(0f, 0.5f, 0f);
        }
        else if (other.gameObject.CompareTag("Yellow Pillar"))
        {
            playerInfo.addPlayerPattern("2");
            FPS.transform.position = new Vector3(0f, 0.5f, 0f);
        }
    }
}
