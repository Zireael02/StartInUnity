using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterRun : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(speed * transform.forward * Time.deltaTime, Space.World);
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
}
