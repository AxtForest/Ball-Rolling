using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBug : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rg.GetComponent<Rigidbody>().useGravity = true;
    }
}
