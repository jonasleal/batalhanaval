using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotacao : MonoBehaviour
{
    Embarcacao navio;
    // Start is called before the first frame update
    void Start()
    {
        navio = gameObject.GetComponentInParent<Embarcacao>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (navio.horizontal)
        {
            gameObject.transform.parent.rotation = Quaternion.Euler(0, 0, 90);
            
            navio.AjustarVertical();

            
        }
        else
        {
            gameObject.transform.parent.rotation = Quaternion.Euler(0, 0, 0);
            navio.AjustarHorizontal();
        }
        navio.horizontal = !navio.horizontal;
        

    }
}
