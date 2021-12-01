using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{    
    public int MaxCountInv = 10;
    public List<Item> Items = new List<Item>();
    public GameObject ItemPrefab;


    void Awake() 
    {
        ItemPrefab.SetActive(false);
        if(PlayerPrefs.HasKey("Inventory"))
           JsonUtility.FromJsonOverwrite(GameManager.access.SA.Read("Inventory"), this);
    }
    public void Collect(Item i)
    {
        Items.Add(i);
        GameObject g = Instantiate(ItemPrefab, ItemPrefab.transform.parent);                //g ist eine temporäre Variable
        g.GetComponent<ItemPrefab>().ItemText.GetComponent<Text>().text  = i.Name;          //wir übergeben von g zu i
        g.GetComponent<ItemPrefab>().ItemImage.GetComponent<Image>().sprite = i.Picture;
        g.SetActive(true);

        GameManager.access.SA.SaveBums("Inventory", JsonUtility.ToJson(this));
        Debug.Log(i.Name);      //Sagt mir welches Item ich einsammel
    }
}
