using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public  Slider vidaVisual;
    
        private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
