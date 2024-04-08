using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    [Header ("Segundos de espera antes de la explosión")]
    // Enunciado de apartado

    public float radio;
    public float fuerzaHorizontal;
    public float fuerzaVertical;
    // cuadro para configurar

    public int temporizador;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explorar", temporizador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
