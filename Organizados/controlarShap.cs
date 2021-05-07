using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarShap : MonoBehaviour
{
  // Start is called before the first frame update
    private int anterior;
    private float temp;
    public Material padrao, brilhando;
    Renderer rend;
    private bool a = true;
    public static bool perdeu = false,mudar=false;
    public AudioSource passar;


 

    void Start()
    {
        // anterior = gerador.controle;
        rend = gameObject.GetComponent<Renderer>();
        passar = gameObject.GetComponent<AudioSource>();
        rend.material = brilhando;
        
    }

    // Update is called once per frame
    void Update()
    {
        temp += Time.deltaTime;
        if (temp >= .4f && a)
        {
            rend.material = padrao;
            a = false;
        }
        if (anterior != gerador.controle)
        {
            anterior = gerador.controle;

            Destroy(gameObject); 

        }
       

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("quadrado")) 
        {

            if (gerador.controle != 1)
            {
                perdeu = true;
            Destroy(gameObject);

            }
            else
            {
                gerador.ponto += 1;
                passar.Play();
            }

        }
        if (col.gameObject.CompareTag("triangulo"))
        {
            if (gerador.controle != 2)
            {

                perdeu = true;
            Destroy(gameObject);


            }
            else
            {
                gerador.ponto += 1;
                passar.Play();

            }

        }
        if (col.gameObject.CompareTag("cilindro"))
        {
            if (gerador.controle != 0)
            {
                perdeu = true;
            Destroy(gameObject);

            }
            else
            {
                gerador.ponto += 1;
                passar.Play();

            }

        }

        if (col.gameObject.CompareTag("vazio")) 
        {
            
                mudar=true;
        
        }


    }


}
