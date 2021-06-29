using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortaAviao : Embarcacao
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        escalaX = 2.2f;
        escalaY = 1.7f;
        tamanho = 6;
        Construir();
       

    }

}
