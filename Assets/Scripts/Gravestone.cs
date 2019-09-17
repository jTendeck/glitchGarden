using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollision)
    {
        Attacker attacker = otherCollision.GetComponent<Attacker>();

        if (attacker)
        {
            //TODO animation stuff
        }
    }

}
