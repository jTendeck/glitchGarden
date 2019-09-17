using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        GameObject otherObj = otherCollision.gameObject;
        FindObjectOfType<LivesDisplay>().RemovePlayerHealth(1);
        Destroy(otherObj);
    }
}
