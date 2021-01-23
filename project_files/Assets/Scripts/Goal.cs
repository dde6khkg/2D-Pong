using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.CompareTag("Ball") )
        {
            if( gameObject.name == "UserGoal" )
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().UserScored();
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().AIScored();
            }
        }    
    }
}
