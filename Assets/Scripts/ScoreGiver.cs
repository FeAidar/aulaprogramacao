using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGiver : MonoBehaviour
{
    public int PontosLinha;
    public int PontosArco;
    public Text Score;
    private int Pontos;
    private bool Desliga;
    public Text vidas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "" + Pontos;
        vidas.text = "Vidas: " + FindObjectOfType<Failed>().Vida;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Linha"))
        {
            Debug.Log("teste");
            StartCoroutine ("GivePointLinha");
        }

  }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ring"))
        {

        }
    }

    IEnumerator GivePointLinha()
    {
        
        if (!Desliga)
        {
            Desliga = true;
            Pontos = Pontos+PontosLinha;
        }
        yield return new WaitForSecondsRealtime (0.2f);
        Desliga = false;

    }

    IEnumerator GivePointRing()
    {

        if (!Desliga)
        {
            Desliga = true;
            Pontos = Pontos + PontosArco;
        }
        yield return new WaitForSecondsRealtime(0.2f);
        Desliga = false;

    }
}
