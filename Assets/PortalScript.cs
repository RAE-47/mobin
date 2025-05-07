using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Gamemodes Gamemode;
    public Speeds Speed;
    public bool UprightGravity;
    public int State; 

    void OnCollisionEnter2D(Collision2D collision)
    {  
        try
        {
            Movement movement = collision.gameObject.GetComponent > ();

            //Call a function 
        }
        catch { }
    }
}
 