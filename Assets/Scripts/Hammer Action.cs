using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAction : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
   
    //when the hammer hits the enemy and the enemy detects that then the computer will tell the enemy to destroy itself
}
