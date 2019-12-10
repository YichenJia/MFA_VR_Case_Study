/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class RoomSceneManger : MonoBehaviour
{
    public SteamVR_LaserPointer laser;
    public GameObject screenSceneActivator;
    public GameObject boxSceneActivator;
    public GameObject figureSceneActivator;

    void Awake()
    {
        laser.PointerIn += PInside;
        laser.PointerOut += POutside;
        laser.PointerClick += PClick;
    }

    public void PClick(object sender, PointerEventArgs e)
    {
        Debug.Log("click");
        Debug.Log(e.target.name);
        if (e.target.name == "MODEL_Screen")
        {
            Debug.Log("Sphere-SwitchScene was clicked");
            screenSceneActivator.SetActive(true);
        }
        else if (e.target.name == "MODEL_Box")
        {
            boxSceneActivator.SetActive(true);
        }
        else if (e.target.name == "MODEL_Figure")
        {
            figureSceneActivator.SetActive(true);
        }
    }

    public void PInside(object sender, PointerEventArgs e)
    {
        Debug.Log("enter");
        Debug.Log(e.target.name);
        if (e.target.name == "MODEL_Screen")
        {
            Debug.Log("highlight screen");
        }
        else if (e.target.name == "MODEL_Box")
        {
            Debug.Log("highlight screen");
        }
        else if (e.target.name == "MODEL_Figure")
        {
            Debug.Log("highlight screen");
        }
    }

    public void POutside(object sender, PointerEventArgs e)
    {
        Debug.Log("Exit");
        Debug.Log(e.target.name);
        if (e.target.name == "MODEL_Screen")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "MODEL_Room")
        {
            Debug.Log("Button was exited");
        }
    }
}