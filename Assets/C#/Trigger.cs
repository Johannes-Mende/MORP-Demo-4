using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool isTriggered;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            if (GameManager.access.GL.I.MaxCountInv > 0 && GameManager.access.GL.I.MaxCountInv >= other.GetComponent<Holder>().Items[0].Count)
            {
                GameManager.access.GL.I.MaxCountInv -= other.GetComponent<Holder>().Items[0].Count;
                GameManager.access.GL.I.Collect(other.GetComponent<Holder>().Items[0]);
                other.gameObject.SetActive(false);
            }
            isTriggered = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        isTriggered = false;
    }        

}
