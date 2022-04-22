using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject Hunter;
    public float TimeSpawn;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
    
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Hunter, transform.position, transform.rotation);

    }
}
