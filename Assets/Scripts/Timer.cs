using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float tempo;
    private float _timeRemaining;
    public bool Linha;
    public bool Arco;
    public bool Bomba;

    private void Start()
    {
        _timeRemaining = tempo;
    }

    void Update()
    {
        if (_timeRemaining > 0)
        {
            _timeRemaining -= Time.deltaTime;

        }
        else
        {
            _timeRemaining = 0;
            if (Linha)
            GetComponent<Line>().TiraLinha();

            if (Arco)
                GetComponent<Boia>().StartCoroutine("TiraArco");

            if (Bomba)
                GetComponent<Bomba>().StartCoroutine("TiraBomba");

        }

    }

}