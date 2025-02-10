using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public GameObject Road1;
    public GameObject Road2;
    public GameObject Road3;
    public GameObject SRoad;
    private GameObject DelRoad;
    public float RLength;
    public float RLFr;
    public Vector3 SPos;
    public int Roadnum;
    public float ZPos;
    public float SpawnOffset;


    

    
    public GameObject ObjectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SPos = new Vector3(0,0,0);

        RLFr = RLength;
    }

    // Update is called once per frame
    void Update()
    {
        ZPos = RLFr + SpawnOffset;

        
    }

    void SpawnObject()
    {
        Instantiate(ObjectToSpawn,SPos, ObjectToSpawn.transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            transform.position = new Vector3 (0,0,ZPos);
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
            SPos = SPos + new Vector3 (0,0,RLength);
            SpawnObject();
            RLFr = RLFr + RLength;





        }
    }


}
