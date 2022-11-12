using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DiamondBihaviour : MonoBehaviour
{



    public GameObject me;



    void OnTriggerEnter()
    {
        Destroy(me);
    }
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }
}