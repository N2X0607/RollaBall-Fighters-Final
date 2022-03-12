using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// This script chnages the color of the player to red while in damage state

public class PColor : MonoBehaviour
{


    public DamageState myScript;
    [SerializeField] private Material myMaterial;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<DamageState>();
        DamageState damageState = Player.GetComponent<DamageState>();

    }

    // Update is called once per frame
    void Update()
    {
        myScript = GetComponent<DamageState>();
        DamageState damageState = Player.GetComponent<DamageState>();

        if (damageState.AttackMode == true)
        {
            myMaterial.color = Color.red;
        }


        if (damageState.AttackMode == false)
        {
            myMaterial.color = Color.blue;
        }



    }
}
