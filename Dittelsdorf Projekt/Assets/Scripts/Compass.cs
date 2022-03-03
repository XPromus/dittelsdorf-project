using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    public GameObject Camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var eulerAngles = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, Camera.transform.rotation.eulerAngles.y-180);

    }
}
