using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1,100)]
    public int speed;
    void FixedUpdate()
    {
        Vector3 V3 = new Vector3(GameManager.access.IK.AxisAD,0, GameManager.access.IK.AxisWS);
        GetComponent<Rigidbody>().AddForce(V3*speed);
    }
}
