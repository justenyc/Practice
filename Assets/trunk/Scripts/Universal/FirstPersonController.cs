using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1;
    [SerializeField] float _rotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            Camera.main.transform.position += Camera.main.transform.right * Input.GetAxis("Horizontal")* Time.deltaTime * _moveSpeed;
        }

        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            Camera.main.transform.position += Camera.main.transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;
        }

        if (Input.GetKey(KeyCode.E))
        {
            Camera.main.transform.position += Camera.main.transform.up * Time.deltaTime * _moveSpeed;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Camera.main.transform.position += -Camera.main.transform.up * Time.deltaTime * _moveSpeed;
        }

    }
}
