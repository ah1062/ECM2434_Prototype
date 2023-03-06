using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOne : MonoBehaviour
{
    TrailRenderer tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        
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
