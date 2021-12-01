using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public void SaveBums(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public string Read(string key)
    {
        return PlayerPrefs.GetString(key);
    }
}
