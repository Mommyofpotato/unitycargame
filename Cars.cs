using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public float speed=20.0f;
    public GameObject car;
    
    // Update is called once per frame
    void Update()
    {
        var position = transform.position;
        Vector3 destroyLocation = new Vector3(-5, 0, -17);
        var spawnLocation = GameObject.Find("carSpawn").transform.position;

        var vehiclePosition = GameObject.Find("Vehicle").transform.position;
        transform.Translate(new Vector3(0, 0, 1)*speed*Time.deltaTime);
        

            if (Vector3.SqrMagnitude(position - destroyLocation) < 10.0f)
            {

                Destroy(this.gameObject);
                

            }
        int carCount = GameObject.FindObjectsOfType(typeof(Cars)).Length;
        
        if (carCount == 1)
        {
            Instantiate(this.gameObject, spawnLocation, transform.rotation);
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        
    }

}
