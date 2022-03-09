using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class TouchAndMouse : MonoBehaviour {
    
    [SerializeField] private GameObject leanMultiUpdater;

    void Update() {

        if (Input.touchCount < 1) return;
        
        if (Input.touches[0].phase == TouchPhase.Began) {
            leanMultiUpdater.GetComponent<LeanMultiUpdate>().Use.RequiredMouseButtons = -1;
        }

        if (Input.touches[0].phase == TouchPhase.Ended) {
            leanMultiUpdater.GetComponent<LeanMultiUpdate>().Use.RequiredMouseButtons = 1;
        }

    }
    
}
