using UnityEngine;

public class WarehouseCar : MonoBehaviour, IUsed 
{
    public void Use(PlayerUse user)
    {
        if (!user.hasObj) return;

        user.hasObj = false;

        Debug.Log("Put Obj in the car");
    }
}
