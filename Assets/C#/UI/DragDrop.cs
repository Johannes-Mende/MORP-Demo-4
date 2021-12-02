using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    public EquipmentController.Equippable oneEquip;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public EquipmentController EC;
    public GameObject lastSlot;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

        if (lastSlot != null)
        {
            lastSlot.GetComponent<ItemSlot>().oneEquip = default;          //Slot wird gecleard wenn vorhanden
            EC.access.removeItem(gameObject.GetComponent<DragDrop>().oneEquip.objekt);
        }
        Debug.Log("Slot Saved");
        
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;         
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        
        
        if(eventData.pointerCurrentRaycast.gameObject != null)
        {
            //Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
            GetComponent<DragDrop>().oneEquip.slot = eventData.pointerCurrentRaycast.gameObject;                                            //Übergabe von Item slot auf droped Orb
            lastSlot = eventData.pointerCurrentRaycast.gameObject;                                                                     //Slot wird zwischen gespeichert
            eventData.pointerCurrentRaycast.gameObject.GetComponent<ItemSlot>().oneEquip = gameObject.GetComponent<DragDrop>().oneEquip;    //Slot bekommt werte von droped Orb
            //EC.access.onEquipped(eventData.pointerCurrentRaycast.gameObject);
            
            if (eventData.pointerCurrentRaycast.gameObject.GetComponent<ItemSlot>().EquippableSlot)
            {
                EC.access.addItem(gameObject.GetComponent<DragDrop>().oneEquip.objekt);
            } 

        }
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
        
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
    //https://www.youtube.com/watch?v=BGr-7GZJNXg
}

