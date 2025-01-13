using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vcam : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Xaxis,Yaxis , transform.position.z);
        
    }
}
