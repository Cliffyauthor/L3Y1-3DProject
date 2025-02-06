using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public GameObject Road1;
    public GameObject Road2;
    public GameObject Road3;
    private GameObject DelRoad;
    public Vector3 RLength;
    private Vector3 SPos;

    
    public GameObject ObjectToSpawn;
    // Start is called before the first frame update
    void Start()
    {



        Vector3 SPos = new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void SpawnObject()
    {
        Instantiate(ObjectToSpawn,SPos, ObjectToSpawn.transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            SPos = SPos + RLength;
            int RoadNow = Random.Range(1,4);
            if (RoadNow == 1)
            {
                ObjectToSpawn = Road1;
            }
            if (RoadNow == 2)
            {
                ObjectToSpawn =Road2;
            }        
            if(RoadNow == 3)
            {
                ObjectToSpawn = Road3;
            }
            SpawnObject();
            Destroy(DelRoad);
            DelRoad = ObjectToSpawn;

        }
    }


}
