using UnityEngine;

public class Compass : MonoBehaviour {

    [SerializeField] private GameObject cameraPivot;
    
    void Update() {
        var eulerAngles = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, cameraPivot.transform.rotation.eulerAngles.y-180);
    }
    
}
