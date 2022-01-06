using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject aircraft;
    [SerializeField]
    private KeyCode spawnKey;
    [SerializeField]
    private AirControll ac;

    [SerializeField]
    private AircraftMind last=null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            if (ac.CanGetAircraft())
            {
                GameObject go = Instantiate(aircraft, transform.position, transform.rotation);
                AircraftMind cur = go.GetComponent<AircraftMind>();
                cur.setTargets(last,ac);
                last = cur;
            }
        }
    }
}
