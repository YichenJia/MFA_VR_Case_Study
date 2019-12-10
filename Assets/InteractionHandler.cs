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
    public GameObject Activator1;
    public GameObject ToBeActivate1;
    public GameObject Activator2;
    public GameObject ToBeActivate2;
    public GameObject Activator3;
    public GameObject ToBeActivate3;
    public GameObject Activator4;
    public GameObject ToBeActivate4;

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
        if (e.target.name == Activator1.name)
        {
            ToBeActivate1.SetActive(true);
        }
        else if (e.target.name == Activator2.name)
        {
            Debug.Log("click2");
            ToBeActivate2.SetActive(true);
        }
        else if (e.target.name == Activator3.name)
        {
            Debug.Log("click3");
            ToBeActivate3.SetActive(true);
        }
        else if (e.target.name == Activator4.name)
        {
            Debug.Log("click4");
            ToBeActivate4.SetActive(true);
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