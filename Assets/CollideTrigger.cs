using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR;


public class CollideTrigger : MonoBehaviour
{

    public GameObject objectToActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void onTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "LeftHand")
        {
            print("'Collision with hand detected!");
            objectToActivate.SetActive(true);

        }
    }

    public SteamVR_Action_Boolean TriggerClick;
    private SteamVR_Input_Sources inputSource;


    private void OnEnable()
    {
        TriggerClick.AddOnStateDownListener(Press, inputSource);
    }

    private void OnDisable()
    {
        TriggerClick.RemoveOnStateDownListener(Press, inputSource);
    }

    private void Press(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        //put your stuff here
        print("Success");
    }
}

