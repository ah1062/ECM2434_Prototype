using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFive : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Target") {
            Destroy(gameObject);
        }
    }
    public void applyForce() {
        Slider xSlider, ySlider, zSlider;
        xSlider = GameObject.Find("BrownX Slider").GetComponent<Slider>();
        ySlider = GameObject.Find("BrownY Slider").GetComponent<Slider>();
        zSlider = GameObject.Find("BrownZ Slider").GetComponent<Slider>();

        rb.AddForce(new Vector3(xSlider.value, ySlider.value, zSlider.value) * 1000);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
