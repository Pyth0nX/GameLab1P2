using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject PrefabHammer;
    private GameObject CurrentHammer;
    [SerializeField] private Transform hammerSpawnPosition;
    public bool canSwing;


    // Start is called before the first frame update
    void Start()
    {
        canSwing = true;
    }

    // Upon Pressing Right Mouse Button, does it spawn the Hammer and deletes it after a second
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canSwing == true)
        {
            StartCoroutine(SwingHammer());
        }
    }
    //Spawns the hammer and the rotation
    private void HammerSpawn()
    {
        CurrentHammer = Instantiate(PrefabHammer, hammerSpawnPosition.position, Quaternion.identity);
        CurrentHammer.transform.parent = transform;
        //gameObject.transform.SetParent(transform, true);
        //gameObject.transform.Rotate(0f, 0f, -90f);
    }
    /*
    void MoveHammer()
    {
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && hammerSpawnPosition)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));

            isGrounded = false;
        }
        if (rb.velocity.x < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
    */
    IEnumerator SwingHammer()
    {
        canSwing = false;
        CurrentHammer = Instantiate(PrefabHammer, hammerSpawnPosition.position, Quaternion.identity);
        CurrentHammer.transform.parent = transform;
        yield return new WaitForSeconds(0.5f);
        CurrentHammer.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        yield return new WaitForSeconds(1f);
        canSwing = true;
        Destroy(CurrentHammer);
    }
}


