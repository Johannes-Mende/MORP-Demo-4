using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Inventory I;
    public ThridPersonMovement TPM;
    public bool InvOn = false;
    public Canvas UI;

    public void InventoryOn()
    {
        if (!InvOn)
        {
            UI.gameObject.SetActive(true);
            InvOn = true;
        }
       
    }
    public void InventoryOff()
    {
        UI.gameObject.SetActive(false);
        InvOn = false;

    }
}
