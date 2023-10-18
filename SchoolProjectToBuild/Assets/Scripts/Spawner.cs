using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] locations;
    public float timer;
    private float counter;

    public GameObject[] pickup;

    public bool work = true;

    // Start is called before the first frame update
    void Start()
    {
        counter = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0)
        {
            counter -= Time.deltaTime;
        }
        else if (counter <= 0)
        {
            if (work)
            {
                SpawnPickup();
            }

            counter = timer;
        }
    }


    public void SpawnPickup()
    {
        int loc = Random.Range(0, locations.Length);
        int rand = Random.Range(0, pickup.Length);
        Instantiate(pickup[rand], locations[loc].position, transform.rotation);
    }
}
