using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class topuIt : MonoBehaviour
{
    public static GameObject top;
    public Rigidbody rb;
    public Camera cam1;
    public Vector3 offset;
    private Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        top = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();
        //cam1 = GetComponent<Camera>();
        ScoreText = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        ScoreText.text = KupleriDondur.score.ToString();
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 20);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 20);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 20);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * 20);
        }
    }


}
