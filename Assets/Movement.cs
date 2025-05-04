using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Speeds { Slow = 0,Normal = 1, Fast = 2, Faster = 3, Fastest = 4 };
public class Movement : MonoBehaviour
{
    public Speeds CurrentSpeed;
    //                       0      1      2       3      4
    float[] SpeedValues = { 8.6f, 10.4f, 12.96f, 15.6f, 19.27f };

    public Transform GroundCheckTransform;
    public float GrounCheckRadius;
    public LayerMask GroundMask;

    void Update()
    {
        transform.position += Vector3.right * SpeedValues[(int)CurrentSpeed] * Time.deltaTime;
        if (Input.GetMouseButton(0));

    }
    bool OnGround() 
    {
    return Physics2D.OverlapCircle(GroundCheckTransform.position, GrounCheckRadius, GroundMask);
    }
}
