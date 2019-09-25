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

    float curPX = 0.0f;
    float curPY = 0.0f;
    float curPZ = 0.0f;

    void Update()
    {
        curPX = transform.position.x;
        curPY = transform.position.y;
        curPZ = transform.position.z;

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(SimpleFunction());
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            Load();
        }
    }

    public void Save()
    {
        Debug.Log("Saving Position...");

        //Debug.Log(curPX);
        //Debug.Log(curPZ);

        SavePosition(curPX, curPY, curPZ);
    }

    public void Load()
    {
        Debug.Log("Loading Position...");

        LoadPosition(curPX, curPY, curPZ);

        //Debug.Log(curPX);
        //Debug.Log(curPZ);

        transform.position = new Vector3(curPX, curPY, curPZ);
    }
}
