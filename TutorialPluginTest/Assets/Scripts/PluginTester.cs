using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    const string DLL_NAME = "Tutorial2";

    //[DllImport(DLL_NAME)]
    //private static extern int SimpleFunction();
    [DllImport(DLL_NAME)]
    private static extern void SavePosition(float posX, float posY, float posZ);
    [DllImport(DLL_NAME)]
    private static extern void LoadPosition();
    [DllImport(DLL_NAME)]
    private static extern float getX();
    [DllImport(DLL_NAME)]
    private static extern float getY();
    [DllImport(DLL_NAME)]
    private static extern float getZ();

    float pX = 0.0f;
    float pY = 0.0f;
    float pZ = 0.0f;

    void Update()
    {
        pX = transform.position.x;
        pY = transform.position.y;
        pZ = transform.position.z;

        /*if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(SimpleFunction());
        }*/

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

        Debug.Log(pX);

        SavePosition(pX, pY, pZ);
    }

    public void Load()
    {
        Debug.Log("Loading Position...");

        LoadPosition();

        //Debug.Log(curPX);
        //Debug.Log(curPZ);

        float x = getX();
        float y = getY();
        float z = getZ();

        transform.position = new Vector3(x, y, z);
    }
}
