using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script checks both players health and displays a win or loss screen depending on who wins


public class WinLose : MonoBehaviour
{

    public OpponentHealth myScript;
    public PlayerHealth myScript2;

    public GameObject Opponent;
    public GameObject Player;

    public Text textbox;

    public Text textbox2;


    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<OpponentHealth>();
        myScript2 = GetComponent<PlayerHealth>();

        OpponentHealth opponentHealth = Opponent.GetComponent<OpponentHealth>();
        PlayerHealth playerHealth = Player.GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void Update()
    {


        OpponentHealth opponentHealth = Opponent.GetComponent<OpponentHealth>();
        PlayerHealth playerHealth = Player.GetComponent<PlayerHealth>();


        if (playerHealth.playerhealth <= 0)
        {
            textbox.text = "Game Over";
        }


        if (opponentHealth.opponenthealth <= 0)
        {
            textbox2.text = "You Win!";
        }

    }
}
