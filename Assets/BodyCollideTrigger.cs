using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollideTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject toActivate;

    private void onCollisionEnter(Collision col)
    {
        print("col.name");
        if (col.gameObject.tag == "Player")
        {
            toActivate.SetActive(true);
        }

    }
}
