using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchowRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ScowRay();
    }

    public void ScowRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        //Debug.Log(ray);
        //Debug.Log(ray.origin);
        Debug.DrawLine(ray.origin, ray.direction, Color.green);
    }
}
