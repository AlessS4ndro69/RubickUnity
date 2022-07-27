using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubick : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Cube;
    public GameObject child;
    public GameObject p;
    public bool flag;
    //GameObject p = GameObject.Find("Cube");
    //GameObject p = new GameObject("root");

    void Start()
    {
        //Cube.transform.Rotate(55.0f, 0.0f, 0.0f, Space.Self);
        p = new GameObject("root");
        p.transform.Translate(0.0f, 0.0f, 0.0f);
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag) {

            if (Input.GetKey("q"))
                rotate_x(-1.0f);
            if (Input.GetKey("w"))
                rotate_x(0.0f);
            if (Input.GetKey("e"))
                rotate_x(1.0f);
            if (Input.GetKey("a"))
                rotate_y(-1.0f);
            if (Input.GetKey("s"))
                rotate_y(0.0f);
            if (Input.GetKey("d"))
                rotate_y(1.0f);

        }
        if (Input.GetKey("r"))
            unparent();


    }


    void unparent() {
        flag = false;
        for (int i = 0; i < p.transform.childCount; i++)
        {
            child = p.transform.GetChild(i).gameObject;
            child.transform.parent = Cube.transform;
        }
        flag = true;
        
        
        
    }
    
    void rotate_x(float axis) {

        //GameObject p = GameObject.Find("Cube");
        //p = new GameObject("root");
        //p.transform.Translate(0.0f, 0.0f, 0.0f);

        for (int i = 0; i < Cube.transform.childCount; i++)
        {
            child = Cube.transform.GetChild(i).gameObject;
            if (child.transform.position.x == axis)
            {
                child.transform.parent = p.transform;
                
                //child.transform.Rotate(2.0f, 0.0f, 0.0f, Space.World);
            }

        }
        p.transform.Rotate(15.0f, 0.0f, 0.0f, Space.World);
        //unparent();
        //Destroy(p);



    }

    void rotate_y(float axis)
    {

        for (int i = 0; i < Cube.transform.childCount; i++)
        {
            child = Cube.transform.GetChild(i).gameObject;
            if (child.transform.position.y == axis)
            {
                child.transform.parent = p.transform;

                //child.transform.Rotate(2.0f, 0.0f, 0.0f, Space.World);
            }

        }
        p.transform.Rotate(0.0f, 5.0f, 0.0f, Space.World);
    }


}
