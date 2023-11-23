using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public Animator window;
    [SerializeField] private bool isOpen = false;
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
        if (!isOpen)
        {
            Debug.Log("Opening Door");
            window.SetTrigger("window_trig");
            isOpen = true;
        }
        else
        {
            Debug.Log("Closing Door");
            window.SetTrigger("window_trig");
            isOpen = false;
        }
    }
}
