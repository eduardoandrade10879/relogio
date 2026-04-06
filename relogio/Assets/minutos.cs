using UnityEngine;
using System;

public class minutos : MonoBehaviour
{
    [SerializeField] Transform ponteiro_minuto;
    Vector3 rotacao_ponteiro_minuto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacao_ponteiro_minuto = ponteiro_minuto.transform.localEulerAngles;
        rotacao_ponteiro_minuto.y = DateTime.Now.Minute * -6;
        ponteiro_minuto.transform.localEulerAngles = rotacao_ponteiro_minuto;
    }
}
