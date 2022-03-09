using System;
using System.Collections.Generic;
using UnityEngine;
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
    [SerializeField] private GameObject landscape;

    private int currentActiveGroup;
    
    void Start() {
        SetToggleButtonText();
        SetTimeTo(0);
    }

    private void SetToggleButtonText() {
        
        var childrenCount = transform.childCount;

        for (var i = 0; i < childrenCount; i++) {
            var child = transform.GetChild(i);
            child.GetComponentInChildren<Text>().text = years[i].year;
        }
        
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
            landscape.GetComponent<Renderer>().material = years[currentActiveGroup].drawnMap;
        } else {
            landscape.GetComponent<Renderer>().material = years[currentActiveGroup].realMap;
        }
        
    }

}
