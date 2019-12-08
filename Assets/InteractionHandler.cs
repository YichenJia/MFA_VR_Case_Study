/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class InteractionHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laser;
    public GameObject ToBeActivate;

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
        if (e.target.name == "Sphere-SwitchScene")
        {
            Debug.Log("Sphere-SwitchScene was clicked");
            ToBeActivate.SetActive(true);
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was clicked");
        }
    }

    public void PInside(object sender, PointerEventArgs e)
    {
        Debug.Log("enter");
        Debug.Log(e.target.name);
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void POutside(object sender, PointerEventArgs e)
    {
        Debug.Log("Exit");
        Debug.Log(e.target.name);
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
        }
    }
}