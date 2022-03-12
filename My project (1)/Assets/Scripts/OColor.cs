using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script changes the color of the opponent to red while in damage state


public class OColor : MonoBehaviour
{


    public DamageState myScript;
    [SerializeField] private Material myMaterial;
    public GameObject Opponent;

    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<DamageState>();
        DamageState damageState = Opponent.GetComponent<DamageState>();
    }

    // Update is called once per frame
    void Update()
    {
        myScript = GetComponent<DamageState>();
        DamageState damageState = Opponent.GetComponent<DamageState>();


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

