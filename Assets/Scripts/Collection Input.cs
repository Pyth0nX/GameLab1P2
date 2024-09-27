using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//truusing static UnityEditor.Progress;

public class CollectionInput : MonoBehaviour
{
    [SerializeField] CattoMeter cattoMeter;
    [SerializeField] EnemyScript enemyScript;
    // Start is called before the first frame update
    void Start()
    {
        var g = FindObjectsOfType<Collectable>();
        foreach (Collectable item in g)
        {
            item.OnCollected += Collect;
        }
    }

    private void Collect(Collectable c)
    {
        Debug.Log("Fish obtained!");
        c.OnCollected -= Collect;
        Destroy(c.gameObject);
        cattoMeter.IncreasePower(10f);
    }

    public void LoseFish()
    {

        Debug.Log("You have lost fish");
        cattoMeter.DecreasePower(10f);
        //this one needs to lose fish when the rat hits the player, the rat needs to ask collectionInput to run this code.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
