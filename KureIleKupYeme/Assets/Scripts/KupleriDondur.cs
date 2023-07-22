using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupleriDondur : MonoBehaviour
{
    public static int score;
    GameObject kup;
    GameObject go;
    public static Transform posusyon;
    public static bool destroyed;
    // Start is called before the first frame update
    void Start()
    {
        kup = GetComponent<GameObject>();
        //gameObject.transform.Rotate(55, 66, 77);
    }

    // Update is called once per frame
    void Update()

    {
        
        gameObject.transform.Rotate(Vector3.one * 100 * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Sphere")
        {
            //posusyon = gameObject.transform;
            
            destroyed = true;
            score = score + 10;
            if (yeniKupOlusturma.created)
            {
                Destroy(gameObject);
                yeniKupOlusturma.created = true;
            }
            
        }
    }
}
