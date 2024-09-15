using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
   private Rigidbody rb;
   private AudioSource source;

    public int forcaPulo = 10;

    public bool noChao = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb); 
        TryGetComponent(out source);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "chão")
       {
        noChao = true;
       }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 pra tras, 1 pra frente
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    
        
        
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            //pulo
            source.Play();
            rb.AddForce(Vector3.up * forcaPulo,ForceMode.Impulse);
            noChao = false;
        }

        
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}