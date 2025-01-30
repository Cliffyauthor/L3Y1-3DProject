using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    public float followSpeed;
    public Transform target;
    public float zOffset;
    public float CamMoveR;
    public float CamMoveL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0,5,zOffset);
        transform.position = Vector3.Lerp(transform.position, target.position + offset,  followSpeed * Time.deltaTime);        
            
        if (GameObject.Find("Car").GetComponent<CarController>().XAxis <CamMoveR && GameObject.Find("Car").GetComponent<CarController>().XAxis >CamMoveL)
        {
            transform.position = new Vector3(Xaxis,transform.position.y , transform.position.z);
        }    


    }

}
