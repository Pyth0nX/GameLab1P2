using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] CattoMeter cattoMeter;
    [SerializeField] CollectionInput collectionInput;
    public GameObject pointsMeter;
    // Start is called before the first frame update

    private Transform target;
    public float speed;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(new Vector3(transform.position.x, target.position.y, transform.position.z));

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (target.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointsMeter.GetComponent<CollectionInput>().LoseFish();

        }
        if (collision.gameObject.tag == "Hammer")
        {
            Destroy(collision.gameObject);
        }
    }
/*
    public void RotateToTarget()
    {
        float offset = 180f;
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan(direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle * offset));
    }
*/
}
