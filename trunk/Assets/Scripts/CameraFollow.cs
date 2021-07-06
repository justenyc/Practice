using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float offSetY;
    public float offSetZ;

    public float distance;
    public float turnSpeed;
    public float tiltSpeed;

    public float yMinLimit;
    public float yMaxLimit;

    public float minDistance;
    public float maxDistance;

    Rigidbody rb;

    float x;
    float y;

	// Use this for initialization
	void Start () {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        rb = GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.freezeRotation = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (target)
        {
            x += Input.GetAxis("Horizontal") * turnSpeed * distance;
            y -= Input.GetAxis("Vertical") * tiltSpeed;

            y = ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            distance = Mathf.Clamp(distance, minDistance, maxDistance);
            RaycastHit hit;
            /*if(Physics.Linecast(target.position, transform.position, out hit))
            {
                distance -= hit.distance;
            }*/
            Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
            Vector3 position = rotation * negDistance + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
        //transform.rotation = Quaternion.AngleAxis(Input.GetAxis("Horizontal"), Vector3.up);
        //transform.position = new Vector3(offSetX, target.position.y + offSetY, target.position.z + offSetZ);
	}

    void Orbit()
    {
        transform.position = new Vector3(transform.position.x, target.position.y + offSetY, target.position.z + offSetZ);
        transform.rotation = Quaternion.AngleAxis(Input.GetAxis("Horizontal"), target.up);
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
