using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    const string DLL_NAME = "Tutorial2";

    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();
    [DllImport(DLL_NAME)]
    private static extern void SavePosition(float posX, float posY, float posZ);
    [DllImport(DLL_NAME)]
    private static extern void LoadPosition(float posX, float posY, float posZ);

    float pX = 0.0f;
    float pY = 0.0f;
    float pZ = 0.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(SimpleFunction());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    public void Save()
    {
        Debug.Log("Saving Position...");

        pX = transform.position.x;
        pY = transform.position.y;
        pZ = transform.position.z;

        SavePosition(pX, pY, pZ);
    }

    public void Load()
    {
        Debug.Log("Loading Position...");

        LoadPosition(pX, pY, pZ);

        transform.Translate(pX, pY, pZ);
    }
}
