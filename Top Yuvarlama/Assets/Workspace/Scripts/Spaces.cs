using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaces : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
        Time.timeScale = 0;
        panel.SetActive(true);
        
    }
}
