using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MouseOrbit : MonoBehaviour
{
    public Transform target;
    public float maxOffsetDistance = 2000f;
    public float orbitSpeed = 15f;
    public float panSpeed = .5f;
    public float zoomSpeed = 10f;
    private Vector3 targetOffset = Vector3.zero;
    private Vector3 targetPosition;


    // Use this for initialization
    void Start()
    {
        if (target != null) transform.LookAt(target);
    }



    void Update()
    {
        targetPosition = target.position + targetOffset;


        if (target != null)
        {
            targetPosition = target.position + targetOffset;

            // Left Mouse to Orbit
            if (Input.GetMouseButton(0))
            {
                transform.RotateAround(targetPosition, Vector3.up, Input.GetAxis("Mouse X") * orbitSpeed);
                float pitchAngle = Vector3.Angle(Vector3.up, transform.forward);
                float pitchDelta = -Input.GetAxis("Mouse Y") * orbitSpeed;
                float newAngle = Mathf.Clamp(pitchAngle + pitchDelta, 0f, 180f);
                pitchDelta = newAngle - pitchAngle;
                transform.RotateAround(targetPosition, transform.right, pitchDelta);
            }
            // Right Mouse To Pan
            if (Input.GetMouseButton(1))
            {
                Vector3 offset = transform.right * -Input.GetAxis("Mouse X") * panSpeed + transform.up * -Input.GetAxis("Mouse Y") * panSpeed;
                Vector3 newTargetOffset = Vector3.ClampMagnitude(targetOffset + offset, maxOffsetDistance);
                transform.position += newTargetOffset - targetOffset;
                targetOffset = newTargetOffset;
            }


            // Scroll to Zoom
            transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        }
    }
}// CLASS