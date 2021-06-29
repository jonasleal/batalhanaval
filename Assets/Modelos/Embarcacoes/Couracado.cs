using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couracado : Embarcacao
{
    // Start is called before the first frame update
    void Start()
    {
        escalaX = 1.4f;
        escalaY = 1.4f;
        tamanho = 3;
        Construir();
    }

}
