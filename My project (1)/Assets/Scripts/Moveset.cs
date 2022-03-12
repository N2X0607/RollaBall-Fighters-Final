using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;





public class Moveset : MonoBehaviour
{
   
    
    public DamageState myScript;
    
    


    
    
    public GameObject Player;
    public GameObject PickUp;
    public GameObject PickUp2;
    public GameObject PickUp3;
    public GameObject PickUp4;
    public GameObject PickUp5;
    public GameObject PickUp6;
    public GameObject PickUp7;
    public GameObject PickUp8;
    public GameObject PickUp9;

    public GameObject Opponent;
    
    
    NavMeshAgent agent;
    

    // Start is called before the first frame update
    void Start()
    {
        
	myScript = GetComponent<DamageState>();  
	agent = GetComponent<NavMeshAgent>();
    DamageState damageState = Opponent.GetComponent<DamageState>();
    print("DamgaeState" + damageState.AttackMode); 

    }

    // Update is called once per frame
    void Update()
    {

        DamageState damageState = Opponent.GetComponent<DamageState>();


        // Moves the opponent towards either a powerup or the player, depending on if it 	   is in damage state



        if (damageState.AttackMode == false)
	    {

            if (PickUp != null)
            {
                agent.destination = PickUp.transform.position;
            }

            if (PickUp2 != null)
            {
                agent.destination = PickUp2.transform.position;
            }

            if (PickUp3 != null)
            {
                agent.destination = PickUp3.transform.position;
            }

            if (PickUp4 != null)
            {
                agent.destination = PickUp4.transform.position;
            }

            if (PickUp5 != null)
            {
                agent.destination = PickUp5.transform.position;
            }

            if (PickUp6 != null)
            {
                agent.destination = PickUp6.transform.position;
            }

            if (PickUp7 != null)
            {
                agent.destination = PickUp7.transform.position;
            }

            if (PickUp8 != null)
            {
                agent.destination = PickUp8.transform.position;
            }

            if (PickUp9 != null)
            {
                agent.destination = PickUp9.transform.position;
            }










        }


        if (damageState.AttackMode == true)
	    {

	    agent.destination = Player.transform.position;
	    }
    

     }
    



    


}

