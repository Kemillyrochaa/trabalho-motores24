using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

private void OnTriggerEnter(Collider other)
{
    if(other.tag == "Player")
    {
        FindObjectOfType<GameManager>().Subtrairmoedas(1);
        Destroy(gameObject);
    }
}
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidadeGiro * Time.deltaTime,Space.World);
    }
}
