
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DOF_Controll : MonoBehaviour
{

    PostProcessVolume Volume;
    DepthOfField DOF;

    public PostProcessProfile PostProfile;
    public GameObject TargetObject;


    // Start is called before the first frame update
    void Start()
    {
        PostProfile.TryGetSettings(out DOF);
        //DOF.active = true;

    }

    
    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(TargetObject.transform.position, transform.position);
        DOF.focusDistance.value = dist;
    }

    public void SetPosition()
    {
        float dist = Vector3.Distance(TargetObject.transform.position, transform.position);
        GetComponent<Lean.Common.LeanMaintainDistance>().Distance = dist;

    }

}

