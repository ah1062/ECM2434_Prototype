using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThree : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    TrailRenderer tr;

    private float thrust = 250f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        tr = GetComponent<TrailRenderer>();
        m_Rigidbody.AddForce(new Vector3(-thrust, thrust, 0));
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Target") {
            tr.transform.parent = null;
            tr.autodestruct = true;
            tr = null;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
