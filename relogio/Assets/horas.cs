using UnityEngine;
using System;

public class horas : MonoBehaviour
{
    [SerializeField] Transform ponteiro_hora;
    Vector3 rotacao_ponteiro_hora;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacao_ponteiro_hora = ponteiro_hora.transform.localEulerAngles;
        rotacao_ponteiro_hora.y = DateTime.Now.Hour * -12;
        ponteiro_hora.transform.localEulerAngles = rotacao_ponteiro_hora;
    }
}
