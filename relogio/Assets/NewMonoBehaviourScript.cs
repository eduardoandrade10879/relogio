using UnityEngine;
using System;

public class relogio : MonoBehaviour

{
    [SerializeField] int segundos_atuais;
    [SerializeField] Transform ponteiro_segundo;
    Vector3 segundo_rotacao = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        segundos_atuais = DateTime.Now.Second;
        segundo_rotacao = ponteiro_segundo.localEulerAngles;
        segundo_rotacao.y = segundos_atuais * 6 * (-1);
        ponteiro_segundo.localEulerAngles = segundo_rotacao;
    }


}




