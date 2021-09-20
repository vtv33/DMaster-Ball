using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBumper : MonoBehaviour
{
    public string Axis = "x";
    public float Distaint = 3f;
    public float speed = 3f;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Axis == "x")
        {
            transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time * speed, Distaint*2) - Distaint, pos.y, pos.z);
        }
        else
            transform.position = new Vector3(pos.x, pos.y, pos.z + Mathf.PingPong(Time.time * speed, Distaint * 2) - Distaint);
    }
}
