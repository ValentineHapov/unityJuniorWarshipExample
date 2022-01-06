using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarshipMoving : MonoBehaviour
{
    [SerializeField]
    private string HorizontalAxisName = "Horizontal";
    [SerializeField]
    private string VerticalAxisName = "Vertical";

    [SerializeField]
    private float acceleration = 5f;
    [SerializeField]
    private float currentSpeed = 0f;
    [SerializeField]
    private float RotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed += Input.GetAxis(VerticalAxisName) * acceleration * Time.fixedDeltaTime;
        transform.Rotate(0, RotateSpeed*Time.fixedDeltaTime*Input.GetAxis(HorizontalAxisName), 0);
        transform.Translate(0, 0, currentSpeed);
    }
}
