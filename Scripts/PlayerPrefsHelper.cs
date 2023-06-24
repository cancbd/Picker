using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsHelper
{
    public static void SetVector3(string key, Vector3 value)
    {
        PlayerPrefs.SetFloat(key + ".x", value.x);
        PlayerPrefs.SetFloat(key + ".y", value.y);
        PlayerPrefs.SetFloat(key + ".z", value.z);
        PlayerPrefs.Save();
    }

    public static Vector3 GetVector3(string key)
    {
        float x = PlayerPrefs.GetFloat(key + ".x");
        float y = PlayerPrefs.GetFloat(key + ".y");
        float z = PlayerPrefs.GetFloat(key + ".z");
        return new Vector3(x, y, z);
    }
}