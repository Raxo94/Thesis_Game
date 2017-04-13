using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {
    int count;
    public movement player;

    // Use this for initialization

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && gameObject != player.latestCollisionObject)
        {
            player.latestCollisionObject = gameObject;
            player.collisionCount++;
            print(player.collisionCount);
            


        }
    }
}
