using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Speeds { Slow = 0,Normal = 1, Fast = 2, Faster = 3, Fastest = 4 };
public enum Gamemodes { Cube = 0, Ship = 1}
public class Movement : MonoBehaviour
{
    public Speeds CurrentSpeed;
    //                       0      1      2       3      4
    float[] SpeedValues = { 8.6f, 10.4f, 12.96f, 15.6f, 19.27f };

    public Transform GroundCheckTransform;
    public float GrounCheckRadius;
    public LayerMask GroundMask;
    public Transform Sprite;

    Rigidbody2D rb;

   void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.position += Vector3.right * SpeedValues[(int)CurrentSpeed] * Time.deltaTime;

        if (OnGround())
        {
            Vector3 Rotation = Sprite.rotation.eulerAngles;
            Rotation.z = Mathf.Round(Rotation.z / 90) * 90;
            Sprite.rotation = Quaternion.Euler(Rotation); 

            if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.zero; 
                rb.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);
            }  
        }
        else 
        {
           Sprite.Rotate(Vector3.back * 5);
        }
    }
    bool OnGround() 
    {
    return Physics2D.OverlapCircle(GroundCheckTransform.position, GrounCheckRadius, GroundMask);
        //Robin
    }
}
