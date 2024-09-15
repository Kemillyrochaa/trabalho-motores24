using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipmoeda, clipVitoria;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

public void Subtrairmoedas(int valor)
{
    restantes -= valor;
hud.text = $"moedas restantes: {restantes}";

source.PlayOneShot(clipmoeda);

    if (restantes <= 0)
    {
//ganhou o jogo
msgVitoria.text = "parabéns!";
source.Stop();
source.PlayOneShot(clipVitoria);
    }
}



    // Update is called once per frame
    void Update()
    {
        
    }
}
