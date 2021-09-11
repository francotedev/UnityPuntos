using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public Puntaje PuntajePJ;
    public int MonedaValor;
    public GameObject MonedaProp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MonedaProp.SetActive(false);
            PuntajePJ.PlayerPuntos = PuntajePJ.PlayerPuntos + MonedaValor;
        }
    }
}
