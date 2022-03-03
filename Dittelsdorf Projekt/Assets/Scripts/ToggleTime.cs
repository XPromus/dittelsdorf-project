using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTime : MonoBehaviour
{
    public List<GameObject> Buildings;
    public GameObject Landscape;
    public List<Material> Map;

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
        Landscape.GetComponent<Renderer>().material = Map[atime];
    }

}
