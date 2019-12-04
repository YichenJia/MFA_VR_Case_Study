using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.name == "objectToActivate")
        {
            Debug.Log("'Collision with hand detected!");
            objectToActivate.SetActive(true);

        }
    }
}
