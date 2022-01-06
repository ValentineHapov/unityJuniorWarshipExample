using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    [SerializeField]
    private float minSpeed = 20f;

    [SerializeField]
    private float maxSpeed = 30f;

    [SerializeField]
    private float maxAngleSpeed = 30f;//Скорость вращения самолета (Градусов/секунду)

    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private float deathTime = 20f;
    private float maxAngle;
    // Start is called before the first frame update
    void Start()
    {
        speed = minSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (deathTime >= 0)
        {
            maxAngle = maxAngleSpeed * Time.fixedDeltaTime;
            transform.Translate(0, 0, speed);
            deathTime -= Time.fixedDeltaTime;
        }
    }
    public void setRotate(float y)
    {
        if (deathTime >= 0)
            transform.Rotate(0, Mathf.Clamp(y,-maxAngle,maxAngle), 0);
    }

    public void setSpeed(float speed)
    {
        this.speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
    }
}
