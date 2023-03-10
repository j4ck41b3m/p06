using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    public bool camera1Enabled;

    // Start is called before the first frame update

    void Start()
    {
        camera1Enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camera1Enabled)
            {
                camera1.GetComponent<Camera>().enabled = true;
                camera1.GetComponent<AudioListener>().enabled = true;

                camera2.GetComponent<Camera>().enabled = false;
                camera2.GetComponent<AudioListener>().enabled = false;
            }
            else
            {
                camera2.GetComponent<Camera>().enabled = true;
                camera2.GetComponent<AudioListener>().enabled = true;

                camera1.GetComponent<Camera>().enabled = false;
                camera1.GetComponent<AudioListener>().enabled = false;
                camera1Enabled = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            camera1Enabled = false;

        }
    }
}
