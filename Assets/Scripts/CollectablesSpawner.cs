using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesSpawner : MonoBehaviour
{
    public float minspawnResetTime = 5f;
    public float maxspawnResetTime = 10f;
    public bool activeAtStart;
    public bool active;
    public GameObject spawnObject;
    GameObject objectSpawned;    
   
    public Vector2 varMin;
    public Vector2 varMax;
    
    //Shoot playerGun;

    // Start is called before the first frame update
    void Start()
    {
        //playerGun = GameObject.FindGameObjectWithTag("AbilityShoot").GetComponent<Shoot>();
        GetComponent<SpriteRenderer>().enabled = false;

        if (activeAtStart)
        {
            Invoke("Spawn", 0f);
            InvokeRepeating("SpawnCheck", 1f, 1f);
        }        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCheck()
    {
        if (active == true && !objectSpawned && !IsInvoking("Spawn"))
        {
            float spawnResetTime = Random.Range(minspawnResetTime, maxspawnResetTime);
            Invoke("Spawn", spawnResetTime);
        }
    }

    public void Spawn()
    {
        if(spawnObject != null)
        {
            Vector2 pos = transform.position;
            pos.x = pos.x + Random.Range(varMin.x, varMax.x);
            pos.y = pos.y + Random.Range(varMin.y, varMax.y);
            objectSpawned = Instantiate(spawnObject, pos, transform.rotation);
        }
        //spawnObject.name = null;       
    }         
}
