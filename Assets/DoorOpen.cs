using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public Animator door;
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
            door.SetTrigger("door_trig");
            isOpen = true;
        }
        else
        {
            Debug.Log("Closing Door");
            door.SetTrigger("door_trig");
            isOpen = false;
        }
    }
}