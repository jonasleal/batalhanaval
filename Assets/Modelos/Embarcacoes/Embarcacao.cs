using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embarcacao : MonoBehaviour
{
    Vector3 posicao;
    Vector3 posFinal;
    public Renderer navio;
    public float escalaX = 1;
    public float escalaY = 1;
    public int tamanho = 0;
    public bool horizontal = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AjustarHorizontal()
    {

        if (posicao.x < (tamanho / 2f))
        {
            posicao.x = (tamanho / 2f);
        }
        else if (posicao.x > (12 - tamanho / 2f))
        {
            posicao.x = (12 - tamanho / 2f);
        }
        else
        {
            posicao.x = (int)posicao.x;
            posicao.x += tamanho % 2 == 0 ? 0 : 0.5f;
        }
        if (posicao.y < -10)
        {
            posicao.y = -10.5f;
        }
        else if (posicao.y > -1)
        {
            posicao.y = -0.5f;
        }
        else
        {
            posicao.y = (int)posicao.y;
            posicao.y -= 0.5f;
        }
    }

    public void AjustarVertical()
    {
        print("chamou");
        if (posicao.x < (1))
        {
            posicao.x = 0.5f;
        }
        else if (posicao.x > 11 )
        {
            posicao.x = 11.5f;
        }
        else
        {
            posicao.x = (int)posicao.x;
            posicao.x += 0.5f;
        }


        if (posicao.y < -11 + tamanho/2f)
        {
            posicao.y = -11 + tamanho / 2f;
            posicao.y += tamanho % 2 == 0 ? 0 : 0.5f;
            
        }
        else if (posicao.y > 0 - tamanho/2f)
        {
            posicao.y = 0 - tamanho / 2f;
            posicao.y -= tamanho % 2 == 0 ? 0 : 0.5f;
        }
        else
        {
            posicao.y = (int)posicao.y;
            posicao.y -= tamanho % 2 == 0 ? 0 : 0.5f;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (horizontal)
        {
            AjustarHorizontal();
        }
        else
        {
            AjustarVertical();
        }

        navio.transform.localPosition = posicao;

    }
    public void Construir()
    {
        posicao = new Vector3(Random.Range(1, 11), Random.Range(1, 10), -1);
        navio = GetComponent<Renderer>();
        navio.transform.localScale = new Vector3(escalaX, escalaY, 1.0f);
    }


    private void OnMouseDrag()
    {
        posicao = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        navio.transform.localPosition = posicao;
        
    }
   
}
