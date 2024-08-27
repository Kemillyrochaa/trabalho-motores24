using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;

    public int forcaPulo = 10;

    public bool noChao = false;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb); 
    }
    
    private void OnCollisionEnter(Collision collision)

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y < -5);
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
