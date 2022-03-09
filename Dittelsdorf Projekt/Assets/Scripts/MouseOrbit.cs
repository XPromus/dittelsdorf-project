using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MouseOrbit : MonoBehaviour {
    
    public Transform target;
    public float maxOffsetDistance = 2000f;
    public float orbitSpeed = 15f;
    public float panSpeed = .5f;
    public float zoomSpeed = 10f;
    private Vector3 targetOffset = Vector3.zero;
    private Vector3 targetPosition;

    void Start() {
        if (target != null) transform.LookAt(target);
    }
    
    void Update() {
        
        targetPosition = target.position + targetOffset;

        if (target == null) return;
        
        targetPosition = target.position + targetOffset;

        if (Input.GetMouseButton(0)) {
            transform.RotateAround(targetPosition, Vector3.up, Input.GetAxis("Mouse X") * orbitSpeed);
            var pitchAngle = Vector3.Angle(Vector3.up, transform.forward);
            var pitchDelta = -Input.GetAxis("Mouse Y") * orbitSpeed;
            var newAngle = Mathf.Clamp(pitchAngle + pitchDelta, 0f, 180f);
            pitchDelta = newAngle - pitchAngle;
            transform.RotateAround(targetPosition, transform.right, pitchDelta);
        }
            
        if (Input.GetMouseButton(1)) {
            var offset = transform.right * -Input.GetAxis("Mouse X") * panSpeed + transform.up * -Input.GetAxis("Mouse Y") * panSpeed;
            var newTargetOffset = Vector3.ClampMagnitude(targetOffset + offset, maxOffsetDistance);
            transform.position += newTargetOffset - targetOffset;
            targetOffset = newTargetOffset;
        } 
            
        transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

    }
}