using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_switch : MonoBehaviour
{
 
    public Light light0;
    private bool on = false;
    private void OnMouseDown()
    {
        if (on)
        {
            light0.intensity = 0;
            on = false;
        }
        else
        {
            light0.intensity = 1;
            on = true;
        }
    }
}