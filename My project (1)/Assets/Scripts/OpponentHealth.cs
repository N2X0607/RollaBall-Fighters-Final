using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script establishes the opponents health and applies damage from the player when appropriate

public class OpponentHealth : MonoBehaviour
{

    public float opponenthealth = 100f;
    public DamageState myScript;

    public GameObject Opponent;
    public GameObject Player;
    public Text textbox; 
    

    // Start is called before the first frame update
    void Start()
    {

        myScript = GetComponent<DamageState>();
        DamageState damageState = Player.GetComponent<DamageState>();


    }


    // displays the opponents health


    void Update()
    {


        textbox.text = "Opponent Health:" + opponenthealth;

        if (opponenthealth <= 0f)
        {
            Destroy(gameObject);

            
        }
    }



    // checks players damage state, if they collide while player is in dmg. state, the opponent loses health and the player loses their damage state
                


    void OnTriggerEnter(Collider other)
    {

        DamageState damageState = Player.GetComponent<DamageState>();

        if (other.CompareTag("Player"))
        {


            if (damageState.AttackMode == true)
            {

                opponenthealth = opponenthealth - 25f;

                damageState.AttackMode = false;

                

            }




        }




    }



}
