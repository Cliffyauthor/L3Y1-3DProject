using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{

    public GameObject Road2;
    public GameObject Road3;
    private GameObject NRoad;
    public GameObject SRoad;
    private GameObject NDelRoad;
    private GameObject DelRoad;
    public float RLength;
    public float RLFr;
    public Vector3 SPos;
    public float ZPos;
    public float SpawnOffset;
    public GameObject ObjectToSpawn;

    
    // Start is called before the first frame update
    void Start()
    {
        SPos = new Vector3(0,0,0);

        RLFr = RLength;
        NDelRoad = SRoad;
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
            int RoadNow = Random.Range(1,3);
            if (RoadNow == 1)
            {
                NRoad = ObjectToSpawn;

                ObjectToSpawn = Road3;
                Road3 = NRoad;

            }
            if (RoadNow == 2)
            {
                NRoad = ObjectToSpawn;
                ObjectToSpawn =Road2;
                Road2 = NRoad;
            }        

            SPos = SPos + new Vector3 (0,0,RLength);
            SpawnObject();            
            Destroy(DelRoad);
            RLFr = RLFr + RLength;
            DelRoad = NDelRoad;
            NDelRoad = ObjectToSpawn;






        }
    }


}
