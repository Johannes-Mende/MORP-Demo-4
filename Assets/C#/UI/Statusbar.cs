using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Statusbar : MonoBehaviour
{

    public Slider H_slider;
    public Slider M_slider;
    public Slider S_slider;

    public Text H_text;
    public Text M_text;
    public Text S_text;

    public int maxHealth;
    public int currentHealth;
    public int hitdamage; // Noch nicht implementiert

    public int maxMana;
    public int currentMana;
    public int maxStamina;
    public int currentStamina;

    public Statusbar access;

    // text setzt sich zusammen aus health + / + maxHealth

    void Awake() 
    {
        access = this;
    }
    void Start()
    {

    }


    void Update()
    {
        
    }

    public void SetMaxHealth(int health)
    {
        H_slider.maxValue = health;
        H_slider.value = health;
        maxHealth = health;
        H_text.text = health.ToString() + "/" + maxHealth;
    }
    public void SetHealth(int health)
    {
        H_slider.value = health;
        currentHealth = currentHealth - hitdamage;
    }

    public void SetMaxMana(int mana)
    {
        M_slider.maxValue = mana;
        M_slider.value = mana;
        maxMana = mana;
        M_text.text = mana.ToString() + "/" + maxMana;
    }
    public void SetMana(int mana)
    {
        M_slider.value = mana;
    }

    public void SetMaxStamina(int stamina)
    {
        S_slider.maxValue = stamina;
        S_slider.value = stamina;
        maxStamina = stamina;
        S_text.text = stamina.ToString() + "/" + maxStamina;
    }
    public void SetStamina(int stamina)
    {
        S_slider.value = stamina;
    }
}
