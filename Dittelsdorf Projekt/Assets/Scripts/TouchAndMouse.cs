using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class TouchAndMouse : MonoBehaviour
{
    public GameObject LeanMultiUpdater;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                //Debug.Log("Touch Pressed");
                LeanMultiUpdater.GetComponent<LeanMultiUpdate>().Use.RequiredMouseButtons = -1;
            }

            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                //Debug.Log("Touch Lifted/Released");
                LeanMultiUpdater.GetComponent<LeanMultiUpdate>().Use.RequiredMouseButtons = 1;
            }
        }

    }
}
