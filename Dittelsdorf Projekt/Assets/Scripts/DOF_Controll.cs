using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DOF_Controll : MonoBehaviour {

    private PostProcessVolume volume;
    private DepthOfField depthOfField;

    [SerializeField] private PostProcessProfile postProcessingProfile;
    [SerializeField] private GameObject targetObject;
    
    void Start() {
        postProcessingProfile.TryGetSettings(out depthOfField);
    }
    
    void Update() {
        var dist = Vector3.Distance(targetObject.transform.position, transform.position);
        depthOfField.focusDistance.value = dist;
    }

    public void SetPosition() {
        var dist = Vector3.Distance(targetObject.transform.position, transform.position);
        GetComponent<Lean.Common.LeanMaintainDistance>().Distance = dist;
    }

}