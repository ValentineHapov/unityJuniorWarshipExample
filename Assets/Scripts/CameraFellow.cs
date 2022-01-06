using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
    public Transform player;

    [Range(0, 1)]
    [SerializeField]
    private float lerpSpeed = 0.5f;

    [SerializeField]
    private Vector3 difference;
    // Start is called before the first frame update
    void Start()
    {
        difference = transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position+difference, lerpSpeed);
    }
}
