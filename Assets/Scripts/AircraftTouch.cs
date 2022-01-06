using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftTouch : MonoBehaviour
{
    [SerializeField]
    private AirControll ac;
    [SerializeField]
    private string tag= "Plane";
    [SerializeField]
    private float minDist=20f;


    private void FixedUpdate()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject go in gos)
        {
            if (Vector3.Distance(go.transform.position,transform.position)<=minDist)
            {
                Destroy(go);
                ac.GiveAircraft();
            }    
        }
    }
}
