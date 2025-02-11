using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPart : MonoBehaviour
{
    public Transform target;
    public int Offset;  

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (target.position.x, target.position.y + Offset, target.position.z);
        
    }
}
