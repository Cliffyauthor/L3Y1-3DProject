using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playercollider : MonoBehaviour
{

    public Vector3 lastPos;
    public int VelStart;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("KillTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


        if (other.gameObject.CompareTag("Start"))
        {
            VelStart = 1;
        }
    }



}
