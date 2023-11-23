using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light1;
    public Light light2;

    private bool shining = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (shining == true)
        {
            light1.intensity = 0;
            light2.intensity = 0;
            shining = false;
        }
        else
        {
            light1.intensity = 1;
            light2.intensity = 1;
            shining = true;
        }
    }
}
