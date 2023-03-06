using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFiveButton : MonoBehaviour
{
    BallFive ballFive;
    bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        ballFive = GameObject.Find("Ball5").GetComponent<BallFive>();
    }
    public void buttonPress() {
        if (!pressed) {
            ballFive.applyForce();
            pressed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
