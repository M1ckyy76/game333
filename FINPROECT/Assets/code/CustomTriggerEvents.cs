using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class CustomTriggerEvents : MonoBehaviour
{
    // Start is called before the first frame update



    public UnityEvent on_trigger_enter_custom;
    void OnTriggerEnter()
    {
        on_trigger_enter_custom.Invoke();
    }



    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }
}