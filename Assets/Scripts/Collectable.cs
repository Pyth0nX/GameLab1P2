using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   public event Action<Collectable> OnCollected;
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") // collision.CompareTag("Player");
        {
            OnCollected?.Invoke(this);
            // Trigger Event

        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
