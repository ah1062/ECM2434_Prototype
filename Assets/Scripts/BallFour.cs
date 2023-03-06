using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFour : MonoBehaviour
{
    Rigidbody rb;
    TrailRenderer tr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<TrailRenderer>();
        rb.AddForce(new Vector3(0, 500, 400));
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(4f, 0, 0));
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Target") {
            tr.transform.parent = null;
            tr.autodestruct = true;
            tr = null;
            Destroy(gameObject);
        }
    }

}
