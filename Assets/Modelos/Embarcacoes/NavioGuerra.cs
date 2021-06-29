using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavioGuerra : Embarcacao
{
    // Start is called before the first frame update
    void Start()
    {
        escalaX = 1.7f;
        escalaY = 1.2f;
        tamanho = 4;
        Construir();
    }

   
}
