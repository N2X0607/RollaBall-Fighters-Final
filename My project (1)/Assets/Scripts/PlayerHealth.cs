using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script establishes the players health and applies damage from the player when appropriate

public class PlayerHealth : MonoBehaviour
{


    public float playerhealth = 100f;
    public DamageState myScript;

    public GameObject Opponent;
    public GameObject Player;

    public Text textbox;

    




    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<DamageState>();
        DamageState damageState = Opponent.GetComponent<DamageState>();
        


    }

    // Update is called once per frame



    //displays the players health

    void Update()
    {

        

        textbox.text = "Health:" + playerhealth;

        if (playerhealth <= 0f)
        {

            Destroy(gameObject);

        }

    }




    // checks opponents damage state, if they collide while opponent is in dmg. state, the player loses health and the opponent loses their damage state



    void OnTriggerEnter(Collider other)
    {

        DamageState damageState = Opponent.GetComponent<DamageState>();

        if (other.CompareTag("Opponent"))
        {


            if (damageState.AttackMode == true)
            {

                playerhealth = playerhealth - 25f;

                damageState.AttackMode = false;



            }




        }




    }


}

        

        






    

