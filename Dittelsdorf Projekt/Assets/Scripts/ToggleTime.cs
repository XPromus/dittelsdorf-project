using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTime : MonoBehaviour
{

    [Serializable]
    public struct MapGroup {
        public Material realMap;
        public Material drawnMap;
    }

    [SerializeField] private List<MapGroup> maps;
    [SerializeField] private List<GameObject> Buildings;
    [SerializeField] private GameObject Landscape;
    
    void Start()
    {
        SetTimeTo(0);
    }

    // Start is called before the first frame update
    public void SetTimeTo(int atime)
    {
        foreach (GameObject obj in Buildings)
        {
            obj.SetActive(false);
        }

        Buildings[atime].SetActive(true);
        Landscape.GetComponent<Renderer>().material = maps[atime].realMap;
    }

}
