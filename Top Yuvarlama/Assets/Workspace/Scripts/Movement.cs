using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float hiz;
    float yatay, dikey;
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        yatay = Input.GetAxis("Mouse X");
        dikey = Input.GetAxis("Mouse Y");
        

        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += new Vector3(dikey * Time.deltaTime * hiz, 0, yatay * Time.deltaTime * hiz);
        }
    }
}
