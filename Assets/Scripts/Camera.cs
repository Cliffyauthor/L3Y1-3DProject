using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    public float followSpeed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offset = new Vector3(0,5,-5);
        transform.position = Vector3.Lerp(transform.position, target.position + offset,  followSpeed * Time.deltaTime);        
        transform.position = new Vector3(Xaxis,transform.position.y , transform.position.z);
    }
    private void LateUpdate() 
    {

       
    }
}
