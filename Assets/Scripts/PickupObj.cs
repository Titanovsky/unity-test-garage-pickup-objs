using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour, IUsed   
{
    public void Use(PlayerUse user)
    {
        if (user.hasObj) return;

        Destroy(gameObject);

        user.hasObj = true;

        Debug.Log("Take the obj");
    }
}
