using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeniKupOlusturma : MonoBehaviour
{
    GameObject klon;
    public GameObject go;
    public static bool created;
    public static GameObject plane;
    public static Transform ts;
    public float maxZ, minZ, maxX, minX;
    float randZ, randX;

    // Start is called before the first frame update
    void Start()
    {
        //go = GameObject.Find("sa");
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
    
        ekle();
    }
    
    void ekle()
    {
        
        //randZ = Random.Range(minZ, maxZ);
        //randX = Random.Range(minX, maxX);

        //KupleriDondur.posusyon.position
        //ts.position.x = Random.Range(-50, 50);
        //ts.position.y = Random.Range(-50, 50);
        //ts.position.z = Random.Range(-50, 50);
        ts.position = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        //KupleriDondur.posusyon = go.transform;
        if (KupleriDondur.destroyed == true && created)
        {
            //klon.transform.position = new Vector3(randX, 1, randZ);
            //Instantiate(klon, klon.transform.position, plane.transform.rotation);
            //Instantiate(go,  plane.transform.localScale, plane.transform.rotation);
            Instantiate(go, ts.position, ts.rotation);
            created = false;
        }
    }
}
