using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ToggleTime : MonoBehaviour
{

    [Serializable]
    public struct Year {
        public string year;
        public GameObject buildings;
        public Material realMap;
        public Material drawnMap;
    }

    [SerializeField] private List<Year> years;
    [Space]
    [SerializeField] private Toggle mapToggle;
    [SerializeField] private GameObject Landscape;

    private int currentActiveGroup;
    
    void Start()
    {
        SetTimeTo(0);
    }

    private void SetToggleButtonText() {
        //TODO: Auto generate the User Interface.
        throw new NotImplementedException();
    }

    public void SetTimeTo(int atime) {

        currentActiveGroup = atime;

        for (var i = 0; i < years.Count; i++) {
            years[i].buildings.SetActive(false);
        }
        
        years[currentActiveGroup].buildings.SetActive(true);
        ChangeMap();
        
    }

    public void ChangeMap() {
        
        if (mapToggle.isOn) {
            Landscape.GetComponent<Renderer>().material = years[currentActiveGroup].drawnMap;
        } else {
            Landscape.GetComponent<Renderer>().material = years[currentActiveGroup].realMap;
        }
        
    }

}
