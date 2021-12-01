using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public EquipmentController.Equippable oneEquip;
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("OnDrop");                                                //https://www.youtube.com/watch?v=BGr-7GZJNXg
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        GetComponent<Image>().raycastTarget = false;
        GetComponent<Image>().raycastTarget = true;
    }
}
