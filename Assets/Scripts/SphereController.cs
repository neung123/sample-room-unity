using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    float jumppower = 5f;
    public float power;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
           // rb.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
           rb.AddForce(Vector3.up * power, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal")*power, 0, Input.GetAxis("Vertical")*power);
    }
}
