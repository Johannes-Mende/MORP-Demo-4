using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeys : MonoBehaviour
{
    public float AxisAD, AxisWS;
    void Update()
    {
        AxisAD = Input.GetAxis("Horizontal");
        AxisWS = Input.GetAxis("Vertical");
        
        if(Input.anyKeyDown)    //ToUpper bringt nur Groß Buchstaben
        {
            switch(Input.inputString.ToUpper())
            {
                case "E":
                    //GameManager.access.GL.I.Collect();
                    break;
                case "S":
                    // Speichern
                    break;
                case "C":
                    GameManager.access.GL.InventoryOn();
                    break;
                case "V":
                    GameManager.access.GL.InventoryOff();
                    break;
            }
        }

    }
}
