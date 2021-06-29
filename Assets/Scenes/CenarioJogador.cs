using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioJogador : MonoBehaviour
{
    bool cameraJogador;
    Vector3 jogador;
    Vector3 rival;
    // Start is called before the first frame update
    void Start()
    {
        cameraJogador = true;
        jogador = new Vector3(5.5f, -5f, -10f);
        rival = new Vector3(5.5f, 6f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (cameraJogador)
        {
            Camera.main.transform.position = rival;
            
        }
        else
        {
            Camera.main.transform.position = jogador;
            
        }
        cameraJogador = !cameraJogador;
        
        
    }
}
