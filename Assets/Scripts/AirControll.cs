using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirControll : MonoBehaviour
{
    [SerializeField]
    private uint AirCount = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CanGetAircraft()
    {
        if (AirCount>0)
        { 
            AirCount--;
            return true;
        }
        return false;
    }

    public void GiveAircraft()
    {
        AirCount++;
    }
}
