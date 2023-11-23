using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fanspin : MonoBehaviour
{
    float spinSpeed = 1000.0f;
    private bool spin = false;
    [SerializeField] private float gradient = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spin == true && gradient < Math.PI / 2)
        {
            gradient += 0.001f;
            if (gradient > (float)Math.PI / 2)
            {
                gradient = (float)Math.PI / 2;
            }
        }
        else if (spin == false && gradient > 0)
        {
            gradient -= 0.001f;
            if (gradient < 0)
            {
                gradient = 0;
            }
        }
        float rotation = (float)Math.Sin(gradient) * spinSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

    }

    public void ToggleSpin()
    {
        spin = !spin;
    }
}
