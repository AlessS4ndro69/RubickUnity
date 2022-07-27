using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemethods : MonoBehaviour
{

    public GameObject cube;
    public GameObject sideR;
    public GameObject sideY;
    public GameObject sideB;
    public GameObject sideG;
    public GameObject sideW;
    public GameObject sideGr;

    public GameObject Rubick;

    // public string  = {"" }
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.black;
        sideR.GetComponent<Renderer>().material.color = Color.red;
        sideY.GetComponent<Renderer>().material.color = Color.yellow;
        sideB.GetComponent<Renderer>().material.color = Color.blue;
        sideG.GetComponent<Renderer>().material.color = Color.green;
        sideW.GetComponent<Renderer>().material.color = Color.white;
        sideGr.GetComponent<Renderer>().material.color = Color.gray;

        Rubick.transform.Rotate(55.0f, 0.0f, 0.0f, Space.Self);

    }




    // Update is called once per frame
    void Update()
    {
        cube.GetComponent<Renderer>().material.color = Color.black;
        //sideR.GetComponent<Renderer>().material.color = Color.red;
        //cube.transform.rotation.x = Mathf.Sin(Time.time);

        Rubick.transform.Rotate(45.0f, 0.0f, 0.0f, Space.Self);

    }
}
