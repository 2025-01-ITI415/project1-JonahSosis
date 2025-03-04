using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTemp : MonoBehaviour
{
    private PlayerInfo playerInfo;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInfo = FindObjectOfType<PlayerInfo>();
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
        }
        else if (other.gameObject.CompareTag("Green Pillar"))
        {
            playerInfo.addPlayerPattern("4");
        }
        else if (other.gameObject.CompareTag("Blue Pillar"))
        {
            playerInfo.addPlayerPattern("3");
        }
        else if (other.gameObject.CompareTag("Yellow Pillar"))
        {
            playerInfo.addPlayerPattern("2");
        }
    }
}
