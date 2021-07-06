using UnityEngine;
using System.Collections;

public class RollBall : MonoBehaviour {

    public Transform camLoc;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.anyKey)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(camLoc.forward * Input.GetAxis("Vertical") * moveSpeed, ForceMode.Force);
        }
	}
}
