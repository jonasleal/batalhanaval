using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMarino : Embarcacao
{
    // Start is called before the first frame update
    void Start()
    {
        escalaX = 0.5f;
        escalaY = 0.7f;
        tamanho = 1;
        Construir();
    }

}
