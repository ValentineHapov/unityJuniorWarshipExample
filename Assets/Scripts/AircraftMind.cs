using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftMind : MonoBehaviour
{
    [SerializeField]
    private float timer = 30f;

    [SerializeField]
    private Aircraft ac;

    [SerializeField]
    private float maxDistance = 100f;

    [SerializeField]
    private bool isComingBack = false;

    [SerializeField]
    private float curDistance;
    [SerializeField]
    private Transform curTarget;

    [SerializeField]
    private Transform[] targets;

    [SerializeField]
    private Transform head;

    // Start is called before the first frame update
    void Start()
    {
        curDistance = -1f;
        curTarget = null;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float ydiff = 0;
        if (isComingBack)
        {
            curTarget = targets[0];
            head.LookAt(curTarget);
            ydiff = head.transform.localRotation.eulerAngles.y;
            ac.setSpeed(10);
        }
        else
        {

            curDistance = -1f;
            foreach (Transform cur in targets)
            {
                if (cur)
                {
                    float dist = Vector3.Distance(transform.position, cur.position);
                    if (dist > curDistance)
                    {
                        curDistance = dist;
                        curTarget = cur;
                    }
                }
            }
            head.LookAt(curTarget);

            if (Vector3.Distance(transform.position, curTarget.position) >= maxDistance)
            {
                ydiff = head.transform.localRotation.eulerAngles.y;
            }

            timer -= Time.fixedDeltaTime;
            if (timer <= 0)
            {
                isComingBack = true;
            }
            ac.setSpeed(100);
        }
        ac.setRotate(ydiff);
    }
    public void setTargets(AircraftMind acr, AirControll aco)
    {
        if (acr)
        {
            targets = new Transform[2];
            targets[1] = acr.transform;
        }
        else
            targets = new Transform[1];
        targets[0] = aco.transform;
    }

}
